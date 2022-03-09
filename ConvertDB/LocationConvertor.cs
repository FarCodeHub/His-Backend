using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    public class LocationConvertor : IConvertor
    {

        public void Convert()
        {
            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcCountries = srccontext.Countries.ToList();
            var srcProvinces = srccontext.Provinces.ToList();
            var srcCities = srccontext.Cities.ToList();
            var srcZones = srccontext.Zones.ToList();

            var locations = newContext.GeoLocations.ToList();



            foreach (var item in srcCountries)
            {
                var isCountry = locations.Where(x => x.Title.Equals(item.Title)).FirstOrDefault();
                if (isCountry == null)
                {
                    var country = new HisDBEntities.GeoLocation()
                    {
                        ParentId = null,
                        Title = item.Title,
                        TitleLang2 = item.TitleLang2,
                        Type = 1,
                        LocalId = item.Id
                    };
                    newContext.GeoLocations.Add(country);


                    var provincesCountry = srcProvinces.Where(x => x.CountryId == item.Id).ToList();
                    foreach (var pItem in provincesCountry)
                    {
                        var isProvince = locations.Where(x => x.Title.Equals(pItem.Title)).FirstOrDefault();
                        if (isProvince == null)
                        {
                            var province = new HisDBEntities.GeoLocation()
                            {
                                Parent = country,
                                Title = pItem.Title,
                                TitleLang2 = pItem.TitleLang2,
                                Type = 2,
                                LocalId = pItem.Id,
                            };
                            newContext.GeoLocations.Add(province);


                            var citiesProvince = srcCities.Where(x => x.ProvinceId == pItem.Id).ToList();
                            foreach (var cItem in citiesProvince)
                            {
                                var isCitiy = locations.Where(x => x.Title.Equals(cItem.Title)).FirstOrDefault();
                                if (isCitiy == null)
                                {
                                    var city = new HisDBEntities.GeoLocation()
                                    {
                                        Parent = province,
                                        Title = cItem.Title,
                                        TitleLang2 = cItem.TitleLang2,
                                        Type = 3,
                                        LocalId = cItem.Id,
                                    };
                                    newContext.GeoLocations.Add(city);

                                    var zonesCity = srcZones.Where(x => x.CityId == cItem.Id).ToList();
                                    foreach (var zItem in zonesCity)
                                    {
                                        var isZone = locations.Where(x => x.Title.Equals(zItem.Title)).FirstOrDefault();
                                        if (isZone == null)
                                        {
                                            var zone = new HisDBEntities.GeoLocation()
                                            {
                                                Parent = city,
                                                Title = zItem.Title,
                                                TitleLang2 = zItem.TitleLang2,
                                                Type = 4,
                                                LocalId = zItem.Id,
                                            };
                                            newContext.GeoLocations.Add(zone);

                                        }
                                    }
                                }

                            }

                        }

                    }
                }
            }
            newContext.SaveChanges();
        }
    }
}
