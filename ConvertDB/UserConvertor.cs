using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    public class UserConvertor:IConvertor
    {


        public void Convert()
        {

            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcUser = srccontext.Users.ToList();
            var srcCardCodes = srccontext.CardCodes.ToList();
            var srcUserCardCodes = srccontext.UserCardCodes.ToList();


            var newUserss = newContext.Users.ToList();
            var newPersons = newContext.People.ToList();
            var newCardCodes = newContext.CardCodes.ToList();

            //// --- add cardcodes data
            //foreach (var item in srcCardCodes)
            //{
            //    //---- insert cardcode into cardcode
            //    var cardCode = new HisDBEntities.CardCode()
            //    {
            //        UserName = item.UserName,
            //        Password = item.Password,
            //        HealthNumber = item.HealthNumber,
            //        Token = item.Token,
            //        Serial = item.Serial,
            //        IsUsed = item.IsUsed,
            //        IsPrint = item.IsPrint,
            //        LocalId = item.Id
            //    };
            //    newContext.CardCodes.Add(cardCode);
            //}

            //newContext.SaveChanges();



            foreach (var item in srcUser)
            {
                var person = newPersons.Where(x => x.LocalId == item.PersonId).FirstOrDefault();
                var cardCode = newCardCodes.Where(x => x.LocalId == item.CardCodeId).FirstOrDefault();

                bool isVerify = false;
                if (item.IsVerify == true)
                    isVerify = true;

                var user = new HisDBEntities.User()
                {
                    Person = person,
                    CardCode = cardCode,
                    UserName = item.UserName,
                    Password = item.Password,
                    SmsToken = item.SmsToken,
                    CreateDate = item.CreateDate,
                    IsVerify = item.IsVerify,
                    MacAddress = item.MacAddress,
                    IsSync = item.IsSync,
                    LocalId = item.Id

                };

                newContext.Users.Add(user);
            }
            newContext.SaveChanges();

            foreach(var item in srcUserCardCodes)
            {
                var cardCode = newCardCodes.Where(x => x.LocalId == item.CardCodeId).FirstOrDefault();
                var user = newUserss.Where(x => x.LocalId == item.UserId).FirstOrDefault();

                var userCardCode = new HisDBEntities.UserCardCode()
                {
                    User = user,
                    CardCode = cardCode,
                    CreateDate = item.CreateDate,
                    ExpireDate = item.ExpireDate,
                    IsCurrent = item.IsCurrent,
                    ValidityPeriodId = item.ValidityPeriodId,
                    LocalId = item.Id
                };

                newContext.UserCardCodes.Add(userCardCode);

            }


            newContext.SaveChanges();


        }
    }
}
