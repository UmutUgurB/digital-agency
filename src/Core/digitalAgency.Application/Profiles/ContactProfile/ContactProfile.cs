using AutoMapper;
using digitalAgency.Application.Dtos.Contacts;
using digitalAgency.Application.Features.Contacts.Commands.CreateContact;
using digitalAgency.Application.Features.Contacts.Commands.RemoveContact;
using digitalAgency.Application.Features.Contacts.Commands.UpdateContact;
using digitalAgency.Domain.Entities;

namespace digitalAgency.Application.Profiles.ContactProfile
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactVm>().ReverseMap();
            CreateMap<Contact,CreateContactCommand>().ReverseMap(); 
            CreateMap<Contact,RemoveContactCommand>().ReverseMap(); 
            CreateMap<Contact,UpdateContactCommand>().ReverseMap(); 

        }
    }
}
