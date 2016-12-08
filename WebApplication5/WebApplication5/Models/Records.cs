using System;
using System.Collections.Generic;

namespace mvcApplication.Models
{
    public class Records
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Country { get; set; }
        public string Hotel { get; set; }
        public decimal Prise { get; set; }
        public string gTour { get; set; }
        public List<Records> RecordsList { get; set; }
}
    public class Request
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string tour { get; set; }
        public string email { get; set; }
        public List<Request> RecordsList { get; set; }
    }
}
