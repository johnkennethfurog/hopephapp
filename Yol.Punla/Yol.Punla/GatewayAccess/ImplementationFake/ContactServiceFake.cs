﻿using System.Linq;
using System.Threading.Tasks;
using Yol.Punla.AttributeBase;
using Yol.Punla.Entity;

namespace Yol.Punla.GatewayAccess
{
    [DefaultModuleInterfacedFake(ParentInterface = typeof(IContactService))]
    public class ContactServiceFake : IContactService
    {
        public Task<Contact> GetUserViaEmail(string emailAddress, string companyName) =>
            Task.FromResult<Contact>(FakeData.FakeUsers.Contacts.Where(c => c.EmailAdd == emailAddress).FirstOrDefault());

        public Task<Contact> GetUserProfile(string EmailAdd, string FbId)
        {
            if (string.IsNullOrEmpty(FbId))
                FbId = "zz0876";

            return Task.FromResult(FakeData.FakeUsers.Contacts.Where(c => c.EmailAdd == EmailAdd || c.FBId == FbId).FirstOrDefault());
        }

        public Task<int> PostReceiver(Contact receiver)
        {
            //chito. let's assume that the newly inserted contact has an ID of 1000
            return Task.FromResult<int>(1000);
        }

        public Task<string> PostVerificationCode(string emailAddress)
        {
            return Task.FromResult("1111");
        }
    }
}
