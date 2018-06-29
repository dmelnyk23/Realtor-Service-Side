using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MethodsBLL
    {
        private readonly MethodsDAL _dal = new MethodsDAL();

        public void AddUser(UserDTO userDTO)
        {
            User user = new User()
            {
                ID = userDTO.ID,
                Favourite = userDTO.Favourite,
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Name = userDTO.Name,
                Password = userDTO.Password,
                PhoneNumber = userDTO.PhoneNumber
            };
            _dal.AddUser(user);
        }

        public void ModifyUser(UserDTO userDTO)
        {
            User user = new User()
            {
                ID = userDTO.ID,
                Favourite = userDTO.Favourite,
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Name = userDTO.Name,
                Password = userDTO.Password,
                PhoneNumber = userDTO.PhoneNumber
            };
            _dal.ModifyUser(user);
        }
        public void DeleteUser(UserDTO userDTO)
        {
            User user = new User()
            {
                ID = userDTO.ID,
                Favourite = userDTO.Favourite,
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Name = userDTO.Name,
                Password = userDTO.Password,
                PhoneNumber = userDTO.PhoneNumber
            };
            _dal.DeleteUser(user);
        }

        public List<UserDTO> GetUsers()
        {
            var dalUsers = _dal.GetUsers();
            List<UserDTO> usersDTO = new List<UserDTO>();
            foreach (var item in dalUsers)
            {
                UserDTO userDTO = new UserDTO()
                {
                    ID = item.ID,
                    Favourite = item.Favourite,
                    IsAdmin = item.IsAdmin,
                    Login = item.Login,
                    Name = item.Name,
                    Password = item.Password,
                    PhoneNumber = item.PhoneNumber,
                    Lots = ConvertToLotDTO(item.Lots)
                };
                usersDTO.Add(userDTO);
            }
            return usersDTO;
        }

        public List<LotDTO> ConvertToLotDTO(ICollection<Lot> lotsDAL)
        {
            List<LotDTO> lotsDTO = new List<LotDTO>();
            foreach (var item in lotsDAL)
            {
            LotDTO lotDTO = new LotDTO
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
                Address = ConvertToAddressDTO(item.Address),
                Photos = ConvertToPhotoDTO(item.Photos)
            };
                lotsDTO.Add(lotDTO);
            }
            return lotsDTO;
        }

        public AddressDTO ConvertToAddressDTO(Address address)
        {
            return new AddressDTO
            {
                ID = address.ID,
                City = address.City,
                Country = address.Country,
                Street = address.Street
            };
        }

        public UserDTO ConvertToUserDTO(User user)
        {
            return new UserDTO
            {
                ID = user.ID,
                Favourite = user.Favourite,
                IsAdmin = user.IsAdmin,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Lots = ConvertToLotDTO(user.Lots)
            };
        }

        public User ConvertToUserDAL(UserDTO userDTO)
        {
            return new User
            {
                ID = userDTO.ID,
                Favourite = userDTO.Favourite,
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Name = userDTO.Name,
                Password = userDTO.Password,
                PhoneNumber = userDTO.PhoneNumber
            };
        }

        public ICollection<PhotoDTO> ConvertToPhotoDTO(ICollection<Photo> photo)
        {
            List<PhotoDTO> photosDTO = new List<PhotoDTO>();
            foreach (var item in photo)
            {
                PhotoDTO photoDTO = new PhotoDTO()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photosDTO.Add(photoDTO);
            }
            return photosDTO;
        }

        public List<LotDTO> GetLots()
        {
            return ConvertToLotDTO(_dal.GetLots());
        }

        public void ReserveLot(int id)
        {
            _dal.ReserveLot(id);
        }

        public void AddLot(LotDTO lotDTO)
        {
            Lot lot = new Lot()
            {
                Address = ConvertToAddressDAL(lotDTO.Address),
                Photos = ConvertToPhotoDAL(lotDTO.Photos),
                Apartment = lotDTO.Apartment,
                Description = lotDTO.Description,
                Flour = lotDTO.Flour,
                House = lotDTO.House,
                IsReserved = lotDTO.IsReserved,
                IsSold = lotDTO.IsSold,
                Price = lotDTO.Price,
                RoomsCount = lotDTO.RoomsCount,
                Square = lotDTO.Square,
                User = ConvertToUserDAL(lotDTO.User)
            };
            _dal.AddLot(lot);
        }

        public Lot ConvertToDALLot(LotDTO lotDTO)
        {
            Lot lot = new Lot()
            {
                ID = lotDTO.ID,
                Apartment = lotDTO.Apartment,
                Description = lotDTO.Description,
                Flour = lotDTO.Flour,
                House = lotDTO.House,
                IsReserved = lotDTO.IsReserved,
                IsSold = lotDTO.IsSold,
                Price = lotDTO.Price,
                RoomsCount = lotDTO.RoomsCount,
                Square = lotDTO.Square,
                Address = ConvertToAddressDAL(lotDTO.Address),
                Photos = ConvertToPhotoDAL(lotDTO.Photos)
            };
            return lot;
        }

        public Address ConvertToAddressDAL(AddressDTO addressDTO)
        {
            Address address = new Address()
            {
                City = addressDTO.City,
                Country = addressDTO.Country,
                ID = addressDTO.ID,
                Street = addressDTO.Street
            };
            return address;
        }

        public List<Photo> ConvertToPhotoDAL(ICollection<PhotoDTO>photosDTO)
        {
            List<Photo> photosDAL = new List<Photo>();
            foreach (var item in photosDTO)
            {
                Photo photoDAL = new Photo()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photosDAL.Add(photoDAL);             
            }
            return photosDAL;
        }
    }
}
