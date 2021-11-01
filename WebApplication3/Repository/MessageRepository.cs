//using WebApplication3.Models;
//using Microsoft.Extensions.Options;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApplication3.Repository
//{
//    public class MessageRepository : IMessageRepository
//    {
//        private readonly IOptionsMonitor<NewProductAlertConfig> _newProductAlertconfiguration;

//        public MessageRepository(IOptionsMonitor<NewProductAlertConfig> newProductAlertconfiguration)
//        {
//            _newProductAlertconfiguration = newProductAlertconfiguration;

//        }
//        public string GetName()
//        {
//            return _newProductAlertconfiguration.CurrentValue.ProductName;
//        } 
//    }
//}
