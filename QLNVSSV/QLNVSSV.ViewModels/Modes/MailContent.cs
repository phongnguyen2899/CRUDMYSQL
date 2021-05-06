using System;
using System.Collections.Generic;
using System.Text;

namespace QLNVSSV.Models.Modes
{
    public class MailContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int MailType { get; set; }
    }
}
