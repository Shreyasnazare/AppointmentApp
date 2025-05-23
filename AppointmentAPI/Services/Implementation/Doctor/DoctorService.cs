﻿using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;
using AppointmentAPI.Models.Doctor.DTO;
using AppointmentAPI.Models.Response;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Repository.Interface.Customer;
using AppointmentAPI.Repository.Interface.Doctor;
using AppointmentAPI.Services.Interface.Doctor;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace AppointmentAPI.Services.Implementation.Doctor
{
    public class DoctorService : Service<DoctorDetails>, IDoctorService
    {
        IDoctorRepository _repo;
        private readonly IConfiguration _configuration;
        public DoctorService(IDoctorRepository repo, IConfiguration configuration) : base(repo)
        {
            _repo = repo;
            _configuration = configuration;
        }

        public DoctorModelRes GetDoctorByEmail(string email)
        {
            var details = _repo.GetDoctorDetails(email);
            if (details != null)
            {
                return DoctorDTO.DoctorDTOMap(details);
            }
            return null;
        }

        public List<DoctorModelRes> GetAllDoctor()
        {
            try
            {

                return _repo.GetAll()
                .Select(DoctorDTO.DoctorDTOMap)  // ****** Imp this will call the  DoctorDTO.DoctorDTOMap one by one for each record
                .ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<Response> InsertDoctorDetail(DoctorModelReq req)
        {
            try
            {
                Response res = new Response();


                if (_repo.GetDoctorDetails(req.Email) != null)
                {
                    res.message = "Doctor already exists.";
                    res.success = false;
                }


                DoctorDetails details = DoctorDTO.DoctorDTOReqMap(req);
                if (req.ImageFile != null && req.ImageFile.Length > 0)
                {

                    ValidateImage(req.ImageFile, res);
                    if (!res.success) return res;


                    details.Image = await ConvertToBase64Async(req.ImageFile);

                   // details.ImagePath = await UploadImage(req.ImageFile, res);
                    if (string.IsNullOrEmpty(details.Image))
                    {
                        res.success = false;
                        res.message = "Failed to upload image";
                        return res;
                    }
                }
                _repo.Insert(details);
                _repo.SaveChanges();
                res.success = true;
                res.message = "Doctor details inserted successfully.";
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<Response> UpdateDoctorDetail(DoctorModelReq req)
        {
            try
            {
                Response res = new Response();
                var existingDetails = _repo.GetDoctorDetails(req.Email);
                if (existingDetails == null)
                {
                    res.message = "Doctor does not exist.";
                    res.success = false;
                }

                DoctorDetails details = DoctorDTO.DoctorDTOReqMap(req);
                if (req.ImageFile != null && req.ImageFile.Length > 0)
                {
                    ValidateImage(req.ImageFile, res);
                    if (!res.success) return res;

                    details.Image = await ConvertToBase64Async(req.ImageFile);
                    //  details.ImagePath = await UploadImage(req.ImageFile, res);
                    if (string.IsNullOrEmpty(details.Image))
                    {
                        res.success = false;
                        res.message = "Failed to upload image";
                        return res;
                    }
                }
                _repo.Update(details);
                _repo.SaveChanges();
                //DeleteImage(existingDetails.ImagePath); //delete existing image if any
                res.success = true;
                res.message = "Doctor details updated successfully.";
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ValidateImage(IFormFile image, Response res)
        {
            try
            {

                const long maxFileSize = 5 * 1024 * 1024; // 5 MB
                if (image.Length > maxFileSize)
                {
                    res.message = "File is too large. Max size allowed is 5 MB.";
                    res.success = false;
                    return;
                }



                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
                var extension = Path.GetExtension(image.FileName).ToLowerInvariant();

                if (string.IsNullOrEmpty(extension) || !allowedExtensions.Contains(extension))
                {
                    res.message = "Invalid file format. Only .jpg, .jpeg, and .png are allowed.";
                    res.success = false;
                    return;
                }

                res.success = true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<string> UploadImage(IFormFile image, Response res)
        {
            try
            {
                var uploadsFolder = _configuration["DoctorImageDirectory"].ToString(); ;
                // Create directory if it doesn't exist
                if (!Directory.Exists(uploadsFolder))
                {
                    uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder);
                }

                // Generate a unique filename
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Save the file
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                return filePath;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<string> ConvertToBase64Async(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                var fileBytes = memoryStream.ToArray();
                string base64String = Convert.ToBase64String(fileBytes);
                return base64String;
            }
        }

        public void DeleteImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    Console.WriteLine("Image deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Image not found.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        DoctorRating IDoctorService.GetDoctorRatings(string doctorID)
        {
            try {
                return _repo.GetDoctorRatings(doctorID);
            }
            catch (Exception) { throw; }
        }

        List<DoctorSpecialisation> IDoctorService.GetDoctorSpecialisation(string doctorID)
        {
            try {
                return _repo.GetDoctorSpecialisation(doctorID);
            }
            catch (Exception) { throw; }
        }
    }
}
