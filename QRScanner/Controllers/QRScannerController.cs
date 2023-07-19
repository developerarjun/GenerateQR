using Microsoft.AspNetCore.Mvc;
using QRCoder;
using QRScanner.Models;
using System.Text.Json;

namespace QRScanner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QRScannerController : ControllerBase
    {
        [HttpPost("readQR")]
        public async Task<ActionResult> ReadQRScan()
        {
            return StatusCode(200);
        }

        [HttpPost("generateQR")]
        public async Task<ActionResult> GenerateQR()
        {
            var accountDetail = new Contact
            {
                Id = Guid.NewGuid(),
                FirstName="Arjun",
                LastName="Ghimire",
                Phone="+977-9867278173",
                Email="developerarjun1@gmail.com",
                ImageUrl=string.Format("https://i.stack.imgur.com/2meqv.jpg?s=256&g=1"),
                CompanyName="Devfinity LLC",
                Website=string.Format("https://stackoverflow.com/users/12647344/arjun-ghimire"),
                BioDescription="Software Engineer",
            };
            //ECCLevel Error Correction Level 
            /*
             * Choosing a higher ECL will ensure that the QR code remains readable even after taking damage, 
             * but will also increase the size of the QR code. With each increment in the ECl, 
             * more data modules are added which contain the backed-up data; thus increasing the QR code size.
            */
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(JsonSerializer.Serialize(accountDetail), QRCodeGenerator.ECCLevel.H);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);
            string base64ImageRepresentation = "data:image/png;base64,"+Convert.ToBase64String(qrCodeAsPngByteArr);
            return StatusCode(200, base64ImageRepresentation);
        }
    }
}
