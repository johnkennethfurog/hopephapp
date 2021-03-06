﻿using System.Linq;
using System.Threading.Tasks;
using Yol.Punla.AttributeBase;
using Yol.Punla.Entity;
using Yol.Punla.Mapper;

namespace Yol.Punla.GatewayAccess
{
    [DefaultModuleInterfaced(ParentInterface = typeof(IContactService))]
    public class ContactService : GatewayServiceBase, IContactService
    {
        public ContactService(IServiceMapper serviceMapper) : base(serviceMapper)
        {
           
        }

        public async Task<Contact> GetUserProfile(string EmailAdd, string FbId)
        {
            await Task.Delay(1);
            if (string.IsNullOrEmpty(FbId))
                FbId = "zz0876";

            return FakeData.FakeUsers.Contacts.Where(c => c.EmailAdd == EmailAdd || c.FBId == FbId).FirstOrDefault();
        }

        public async Task<int> PostReceiver(Contact receiver)
        {
            //chito. let's assume that the newly inserted contact has an ID of 1000
            await Task.Delay(1);
            return 1000;
        }

        public async Task<string> PostVerificationCode(string emailAddress)
        {
            await Task.Delay(1);
            return "1111";
        }

        public async Task<Contact> GetUserViaEmail(string emailAddress, string companyName)
        {
            await Task.Delay(1);
            return FakeData.FakeUsers.Contacts.Where(c => c.EmailAdd == emailAddress).FirstOrDefault();
        }
    }
}
