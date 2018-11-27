package myPackage;// Run() is called from myPackage.Scheduling.main() and is where
// the scheduling algorithm written by the user resides.
// User modification should occur within the Run() function.

import java.awt.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;
import java.io.*;

public class SchedulingAlgorithm {

  public static Results Run(int runtime, Vector processVector, Results result) {
    String resultsFile = "E:\\MUM Work\\OperatingSystems\\My Assignments\\Labs\\Lab1 - RoundRobinWay\\src\\myPackage\\Summary-Processes";

    result.schedulingType = "Pre-Emptive";
    result.schedulingName = "Round-Robin";

    int comptime = 0;
    int counterForProcess = 0;
    int totalProcessesCompleted = 0;
    int size = processVector.size();
    //Init sProcess instance to be null
    sProcess process = null;
    try {
      PrintStream out = new PrintStream(new FileOutputStream(resultsFile));

      //Round Robin Approach
      //1 - Pick 1st Process from processVector List, run it for an assigned quantum i.e. CPU TIME (or till it makes a blocking I/O call)
      //2 - Increment its CPU Done time with each iteration
      //3.1 - If 1st process runs out of its assigned quantum, Pick the next process in Queue
      //3.2 - If 1st process gets blocked i.e. process.cpudone == process.ioblocking, put it at the end of queue. Pick the next process in Queue
      //4 - If Process 1 has remaining CPU time and we've reached to the end of Queue, execute it again
      //5 - Repeat the steps un-till all processes have completed their quantum

      while(totalProcessesCompleted < size){

        //Pick 1st process from Queue
        process = (sProcess) processVector.elementAt(counterForProcess);
        out.println("Process: " + counterForProcess + " registered... (" + process.cputime + " " + process.ioblocking + " " + process.cpudone + " " + process.cpudone + ")");

        while(totalProcessesCompleted < size){

          //Case when CPU time for a process is over
          if(process.cpudone == process.cputime){
            out.println("Process: " + counterForProcess + " completed... (" + process.cputime + " " + process.ioblocking + " " + process.cpudone + " " + process.cpudone + ")");
            counterForProcess++;
            totalProcessesCompleted++;
            break;
          }

          //Case when the process is blocked by a disk read (i/o blocked)
          if(process.cpudone == (process.numblocked != 0 ? (process.ioblocking * process.ioblocking) : process.ioblocking)){
            out.println("Process: " + counterForProcess + " I/O blocked... (" + process.cputime + " " + process.ioblocking + " " + process.cpudone + " " + process.cpudone + ")");
            counterForProcess++;
            process.cpudone++;
            process.numblocked++;
            break;
          }
          process.cpudone++;
          comptime++;
        }

        //Checking if we've reached to the end of queue
        if(counterForProcess == size){
          //Checking if we've any processes left with assigned quantums, if yes, start again, else end loop
          if(totalProcessesCompleted < size){
            counterForProcess = 0;
          }
        }
      }
      out.close();
    } catch (IOException e) { /* Handle exceptions */ }
    result.compuTime = comptime;
    return result;
  }
}
