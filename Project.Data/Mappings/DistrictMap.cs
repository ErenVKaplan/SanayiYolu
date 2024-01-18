using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Mappings
{
    public class DistrictMap : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                new District() { Id = Guid.Parse("512809FD-7B48-4A50-A7B7-9DE728F2E5E6"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "ALADAĞ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("9A0FDB95-F2DF-4853-93CB-8D72793F555D"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "CEYHAN", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("0E0063C2-0621-41B7-9206-0348CC2F552D"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "ÇUKUROVA", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("B8D91D22-4FC3-4017-BA4E-AF2DB2E2E59B"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "FEKE", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("A0170E47-E380-4AB1-A0CF-BFFB821A1951"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "İMAMOĞLU", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("6D38973E-425F-4525-BC8F-FFCB2DFE3FB2"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "KARAİSALI", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("B0F22411-44F9-46D1-89A8-4A7B89430857"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "KARATAŞ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("5A57CA40-F365-4130-AAAB-BAEE0E0C282A"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "KOZAN", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("AFEEA71E-D61D-46CE-B794-D24A3E336840"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "POZANTI", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("98798A7D-6F73-497E-8E8C-9AE9DA5D7FAE"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "SAİMBEYLİ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("35C1305D-1443-48C2-B772-179985746711"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "SARIÇAM", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("11EC0101-D748-481F-9DA1-1DE154209694"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "SEYHAN", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("613E812D-5604-4B13-BB86-72F21FEF94AE"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "TUFANBEYLİ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("7A295A66-D91F-4A60-BA71-95262641DD4D"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "YUMURTALIK", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("4833927C-BE8C-4533-8001-F8F5FAC28889"), CityId = Guid.Parse("743531D8-793E-42FB-8FF0-B6BB128370C9"), DistrictCode = "", DistrictName = "YÜREĞİR", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },

                new District() { Id = Guid.Parse("81BD3FD6-9BAF-46D2-A264-C811431A6976"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "BESNİ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("EB33397D-FF11-4965-9D91-05F455B6FD19"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "ÇELİKHAN", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("D74AD0D8-CA87-4F8D-8A82-B159EE2EE72F"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "GERGER", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("2083A543-F6DF-4C6F-8D01-864F9424D465"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "GÖLBAŞI", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("0F63C895-215D-4EFE-B121-55FB832C9DF3"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "KAHTA", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("4876BB81-5125-49BC-9070-FA10F3376BF4"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "MERKEZ", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("5095EAEB-5B51-4D2B-AEA8-33355BF0B42F"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "SAMSAT", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("F581C226-F011-4B1B-8CBB-46EC224A2F1C"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "SİNCİK", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" },
                new District() { Id = Guid.Parse("D3DD068C-1A08-40E2-BF0B-E2196C19025E"), CityId = Guid.Parse("D2AFF33B-0E7F-4032-8759-317FCC628775"), DistrictCode = "", DistrictName = "TUT", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" }

                );
        }
    }
}
