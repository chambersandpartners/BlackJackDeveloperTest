using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJackAPI.Models
{
    public class CreateBlackJackGameModel
    {
        public string PlayerName { get; set; }
        public string DealerName { get; set; }
    }
}