using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{

    //sql deki join işlemi
    public class CarDetailDto:IDto
    {

        public int Id { get; set; }
        public string CarName { get; set; }
        public string Name { get; set; }

        public int DailyPrice { get; set; }
    }   

}
