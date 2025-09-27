using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAn.DAL.Entities;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace DoAn.BUS
{
    public class UserService
    {
        public List<user_> getAllUser()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.user_.ToList();
        }
        public user_ findUser(int userId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.user_.FirstOrDefault(p => p.id == userId);
        }
        public string GetUserNameById(int userId)
        {
            ShoeModel shoeModel = new ShoeModel();
            var user = shoeModel.user_.FirstOrDefault(u => u.id == userId);
            return user != null ? user.username : "Unknown"; 
        }

        //public string findImageStudent(string studentId)
        //{
        //    StudentModel studentModel = new StudentModel();
        //    Student stu = studentModel.Students.FirstOrDefault(p => p.StudentID == studentId);
        //    if (stu != null)
        //    {
        //        return stu.Avatar;
        //    }
        //    return null;
        //}

        public void InsertUser(user_ user)
        {
            ShoeModel shoeModel = new ShoeModel();
            shoeModel.user_.AddOrUpdate(user);
            shoeModel.SaveChanges();
        }
       
        public int TotalUser(List<user_> listUser)
        {
            return listUser.Count;
        }
        public void DeleteUser(int userId)
        {
            ShoeModel shoeModel = new ShoeModel();
            user_ user = shoeModel.user_.FirstOrDefault(p => p.id == userId);
            shoeModel.user_.Remove(user);
            shoeModel.SaveChanges();
        }

        public user_ Login(string username, string password)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                var user = shoeModel.user_
                    .FirstOrDefault(p => p.username == username && p.password == password && p.status == 1); 
                return user;
            }
        }

        private bool IsUsernameExist(string username)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.user_.Any(u => u.username == username);
            }
        }

        private bool IsEmailExist(string email)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.user_.Any(u => u.email == email);
            }
        }

        public string Register(string username, string password, string fullname, string email, string phone, string address)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                if (IsUsernameExist(username))
                {
                    return "Tên đăng nhập đã tồn tại!";
                }

                if (IsEmailExist(email))
                {
                    return "Email đã tồn tại!";
                }

                user_ newUser = new user_
                {
                    username = username,
                    password = password,
                    fullname = fullname,
                    email = email,
                    phone = phone,
                    role = 0,
                    status = 1,
                    address = address
                };

                shoeModel.user_.Add(newUser);
                shoeModel.SaveChanges();
                return "Đăng ký thành công!";
            }
        }



    }
}
