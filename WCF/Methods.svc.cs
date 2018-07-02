using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF.DataContracts;
using WCF.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IMethods
    {
        private readonly MethodsBLL _bll = new MethodsBLL();
        public void AddUser(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                ID = user.ID,
                Favourite = user.Favourite,
                IsAdmin = user.IsAdmin,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber
            };
            _bll.AddUser(userDTO);
        }

        public void ModifyUser(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                ID = user.ID,
                Favourite = user.Favourite,
                IsAdmin = user.IsAdmin,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber
            };
            _bll.ModifyUser(userDTO);
        }
        public void DeleteUser(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                ID = user.ID,
                Favourite = user.Favourite,
                IsAdmin = user.IsAdmin,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber
            };
            _bll.DeleteUser(userDTO);
        }

        public List<User> GetUsers()
        {
            var bllUsers = _bll.GetUsers();
            List<User> users = new List<User>();
            foreach (var item in bllUsers)
            {
                User user = new User()
                {
                    ID = item.ID,
                    Favourite = item.Favourite,
                    IsAdmin = item.IsAdmin,
                    Login = item.Login,
                    Name = item.Name,
                    Password = item.Password,
                    PhoneNumber = item.PhoneNumber,
                    Lots = ConvertToLotWCF(item.Lots)
                };
                users.Add(user);
            }
            return users;
        }

        public ICollection<Lot> ConvertToLotWCF(ICollection<LotDTO> lotsDTO)
        {
            List<Lot> lots = new List<Lot>();
            foreach (var item in lotsDTO)
            {
                Lot lot = new Lot
                {
                    ID = item.ID,
                    Apartment = item.Apartment,
                    Description = item.Description,
                    Flour = item.Flour,
                    House = item.House,
                    IsReserved = item.IsReserved,
                    IsSold = item.IsSold,
                    Price = item.Price,
                    RoomsCount = item.RoomsCount,
                    Square = item.Square,
                    Address = ConvertToAddressWCF(item.Address),
                     Photos = ConvertToPhotoWCF(item.Photos)
                };
                lots.Add(lot);
            }
            return lots;
        }

        public Address ConvertToAddressWCF(AddressDTO addressDTO)
        {
            return new Address
            {
                ID = addressDTO.ID,
                City = addressDTO.City,
                Country = addressDTO.Country,
                Street = addressDTO.Street
            };
        }

        public User ConvertToUserWCF(UserDTO userDTO)
        {
            return new User
            {
                ID = userDTO.ID,
                Favourite = userDTO.Favourite,
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Name = userDTO.Name,
                Password = userDTO.Password,
                PhoneNumber = userDTO.PhoneNumber,
                Lots = ConvertToLotWCF(userDTO.Lots)
            };
        }

        public UserDTO ConvertToUserBLL(User user)
        {
            return new UserDTO
            {
                ID = user.ID,
                Favourite = user.Favourite,
                IsAdmin = user.IsAdmin,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber
            };
        }

        public ICollection<Photo> ConvertToPhotoWCF(ICollection<PhotoDTO> photoDTO)
        {
            List<Photo> photos = new List<Photo>();
            foreach (var item in photoDTO)
            {
                Photo photo = new Photo()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photos.Add(photo);
            }
            return photos;
        }

        public Lot[] GetLots()
        {
            return ConvertToLotWCF(_bll.GetLots()).ToArray();
        }

        public void ReserveLot(int id)
        {
            _bll.ReserveLot(id);
        }

        public void AddLot(Lot lot)
        {
                LotDTO lotDTO = new LotDTO()
                {
                    Address = ConvertToAddressBLL(lot.Address),
                    Photos = ConvertToPhotoBLL(lot.Photos),
                    Apartment = lot.Apartment,
                    Description = lot.Description,
                    Flour = lot.Flour,
                    House = lot.House,
                    IsReserved = lot.IsReserved,
                    IsSold = lot.IsSold,
                    Price = lot.Price,
                    RoomsCount = lot.RoomsCount,
                    Square = lot.Square,
                    User = ConvertToUserBLL(lot.User)
                };
                _bll.AddLot(lotDTO);
            

        }

        public void LotEdit(Lot lot)
        {
            LotDTO lotDTO = new LotDTO()
            {
                Address = ConvertToAddressBLL(lot.Address),
                Photos = ConvertToPhotoBLL(lot.Photos),
                Apartment = lot.Apartment,
                Description = lot.Description,
                Flour = lot.Flour,
                House = lot.House,
                IsReserved = lot.IsReserved,
                IsSold = lot.IsSold,
                Price = lot.Price,
                RoomsCount = lot.RoomsCount,
                Square = lot.Square,
                User = ConvertToUserBLL(lot.User)
            };
            _bll.LotEdit(lotDTO);
        }

        public void DeleteLot(int id)
        {
            _bll.DeleteLot(id);
        }

        public LotDTO ConvertToBLLLot(Lot lot)
        {
            LotDTO lotDTO = new LotDTO()
            {
                ID = lot.ID,
                Apartment = lot.Apartment,
                Description = lot.Description,
                Flour = lot.Flour,
                House = lot.House,
                IsReserved = lot.IsReserved,
                IsSold = lot.IsSold,
                Price = lot.Price,
                RoomsCount = lot.RoomsCount,
                Square = lot.Square,
                Address = ConvertToAddressBLL(lot.Address),
                Photos = ConvertToPhotoBLL(lot.Photos)
            };
            return lotDTO;
        }

        public AddressDTO ConvertToAddressBLL(Address address)
        {
            AddressDTO addressDTO = new AddressDTO()
            {
                City = address.City,
                Country = address.Country,
                ID = address.ID,
                Street = address.Street
            };
            return addressDTO;
        }

        public List<PhotoDTO> ConvertToPhotoBLL(ICollection<Photo> photos)
        {
            List<PhotoDTO> photosBLL = new List<PhotoDTO>();
            foreach (var item in photos)
            {
                PhotoDTO photoDTO = new PhotoDTO()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photosBLL.Add(photoDTO);
            }
            return photosBLL;
        }
    }
}
