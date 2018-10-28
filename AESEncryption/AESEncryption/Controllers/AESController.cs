using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AESEncryption.Models;

namespace AESEncryption.Controllers
{
    public class AESController : ApiController
    {
        [HttpPost]
        [Route("api/AES/DecryptData")]
        public String DecryptData([FromBody] ViewModelEncryptedContent content)
        {
            return CryptoHelper.Decrypt(content.EncData, "Secret Password");
        }
    }
}
