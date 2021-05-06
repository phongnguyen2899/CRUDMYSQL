using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.Models.Modes;
using QLNVSSV.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailContentController : BaseAPIController<MailContent>
    {
        private readonly IMailContentRepository _mailContentRepository;
        public MailContentController(IMailContentRepository mailContentRepository,IBaseRepository<MailContent> baseRepository) : base(baseRepository)
        {
            _mailContentRepository = mailContentRepository;
        }


        [HttpGet("GetMailForemployee/{title}")]
        public IActionResult GetMailForemployee(int title)
        {
            var data = _mailContentRepository.GetMailForemployee(title);
            return Ok(data);
        }

        [HttpPost("SendMail")]
        public IActionResult SendMail([FromBody] SendMailViewModel listEmployeeId)
        {
            var result = _mailContentRepository.Sendmail(listEmployeeId.listId);
            return Ok(result);
        }
    }
}
