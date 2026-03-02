using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleApi.dto.request;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using UMISModuleApi.Entities;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Text;
using UMISModuleAPI.Configuration;
using UMISModuleApi.dto.response;
using System.Net;
using MimeKit;
using MailKit;
using System.Net.Mail;
using Zaabee.SmtpClient;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Net.Mime;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web;
using System.Linq;
using System.Text.Json.Serialization;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private readonly JwtConfig _jwtConfig;
        private string cmd,cmd2,cmd3;
        private string randomNumber;
        private readonly IOptions<conStr> _dbCon;

        public UserController(IOptions<JwtConfig> jwtConfig,IUserService userService, IOptions<conStr> dbCon)
        {   
            _jwtConfig = jwtConfig.Value;
            _userService = userService;
            _dbCon = dbCon;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            try
            {
                var response = _userService.Authenticate(model);
                if (response == null)
                    return BadRequest(new { message = "User Name/Password is Incorrect / Wait Until Your Profile is Approved." });

                return Ok(response);
            
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost("LoginAuthenticate")]
        public IActionResult LoginAuthenticate(LoginRequest model)
        {
            try
            {
                var response = _userService.LoginAuthenticate(model);
                if (response == null)
                    return BadRequest(new { message = "User Name/Password is Incorrect / Wait Until Your Profile is Approved." });

                return Ok(response);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost("verifyPin")]
        public ActionResult verifyPin(verifyPin model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_verifyPin",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e.Message);
            }
        }

        [HttpGet("getUserBranches")]
        public IActionResult getUserBranches(int userID)
        {
            try
            {
                cmd = "select distinct u.userID,u.firstName,cb.branch_id as branchID,b.branch_name,bds.branch_department_section_id from tbl_user_branches as ub inner join users as u on u.userID = ub.userID inner join aimsCMIS.dbo.tbl_company_branch as cb on cb.branch_id = ub.branchID inner join aimsCMIS.dbo.tbl_branch_department_sections as bds on bds.company_branch_id = cb.company_branch_id inner join aimsCMIS.dbo.tbl_branches_loc as b ON b.branch_id = cb.branch_id where u.userID = " + userID + " and bds.department_section_id = 8";
                var appMenu = dapperQuery.Qry<UserBranches>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getDomain")]
        public IActionResult getDomain()
        {
            try
            {
                cmd = "select * from tbl_domain  where isDeleted=0 order by domainTitle asc";
                var response = dapperQuery.Qry<GetDomain>(cmd, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("getEmploymentType")]
        public IActionResult getEmploymentType()
        {
            try
            {
                cmd = "select * from tbl_employment_Type order by employmentTypeTitle asc";
                var appMenu = dapperQuery.Qry<GetEmployementType>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getLocationType")]
        public IActionResult getLocationType()
        {
            try
            {
                cmd = "select * from tbl_location_type";
                var appMenu = dapperQuery.Qry<GetLocationType>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getPassword")]
        public IActionResult getPassword(int userID)
        {
            try
            {
                cmd = "SELECT password from users where userID="+userID+"";
                var appMenu = dapperQuery.Qry<User>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getHobbies")]
        public IActionResult getPassword()
        {
            try
            {
                cmd = "select hobbiesID,hobbiesTitle from tbl_hobbies where isdeleted=0";
                var appMenu = dapperQuery.Qry<GetHobbies>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getCareer")]
        public IActionResult getCareer()
        {
            try
            {
                cmd = "select careerID,careerTitle from tbl_career where isdeleted=0";
                var appMenu = dapperQuery.Qry<GetCareer>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getUserDetail")]
        public IActionResult getUserDetail(int userID)
        {
            try
            {
                cmd = "select * from view_userDetails where userID = " + userID + "";
                var appMenu = dapperQuery.Qry<userDetail>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        // [HttpGet("getMail")]
        // public IActionResult getMail(string Email, string password)
        // {
        //     try
        //    {

        //     //    string senderEmail = "youremail";
        //     //    string senderPassword = "yourpass";

        //     //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //     //    client.EnableSsl = true;
        //     //    client.Timeout = 100000;
        //     //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //     //    client.UseDefaultCredentials = false;
        //     //    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
        //     //    string emailBody = "Hi," + Email + " Your one time password is " + OTP + " . <br />";
        //     //    string subject = "Account verification with OTP";
        //     //    MailMessage mailMessage = new MailMessage(senderEmail, Email, subject, emailBody);
        //     //    mailMessage.IsBodyHtml = true;
        //     //    mailMessage.BodyEncoding = UTF8Encoding.UTF8;
        //     //    client.Send(mailMessage);


        //         using (MailMessage mail = new MailMessage())
        //                 {
        //                     mail.From = new mailaddress("hammad.noor@aimspakistan.edu.pk");
        //                     mail.To.Add(obj.UserName);
        //                     mail.Subject = "New Paasword for Fixed Asset Register Module";
        //                     mail.Body = "Password: " + obj.HashPassword;
        //                     mail.IsBodyHtml = true;

        //                     //* for setting smtp mail name and port
        //                     using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
        //                     {

        //                         //* for setting sender credentials(email and password) using smtp
        //                         smtp.Credentials = new System.Net.NetworkCredential("email","password");
        //                         smtp.EnableSsl = true;
        //                         smtp.Send(mail);
        //                     }
        //                 }
        //                 sqlResponse = "Mail Sent!";
           
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        // }
        
        [HttpPost("updatePassword")]
        public IActionResult updatePassword(changePassword model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_update_password",model,_dbCon);

                return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        // [HttpGet("getAllUser")]
        // public IActionResult getAllUser(int userID)
        // {
        //     try
        //     {
        //         if (userID == 0)
        //         {
        //             cmd = "SELECT * from view_AllUser order by firstName";    
        //         }
        //         else
        //         {
        //             cmd = "SELECT * from view_AllUser Where userID = "+ userID +" order by firstName";
        //         }
        //         var appMenu = dapperQuery.Qry<userDetail>(cmd, _dbCon);
        //         return Ok(appMenu);
        //     }
        //     catch(Exception e)
        //     {
        //         return Ok(e.Message);
        //     }
        // }
        [HttpGet("getUniversity")]
        public IActionResult getUniversity()
        {
            try
            {
                cmd = "select * from tbl_university where isDeleted=0  order by universityName asc";
                var appMenu = dapperQuery.Qry<GetUniversity>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getDegree")]
        public IActionResult getDegree()
        {
            try
            {
                cmd = "select * from tbl_degree where isDeleted=0 order by degreeName asc";
                var appMenu = dapperQuery.Qry<GetDegree>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPost("createUser")]
        public IActionResult createUser(userCreation model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_userCrud",model,_dbCon);

                return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
         [HttpPost("GoogleAuthenticate")]
        public IActionResult GoogleAuthenticate(AuthenticateRequestGoogle model)
        {
            var response = _userService.GoogleAuthenticate(model);
            if (response == null)
                return BadRequest(new { message = "user name or password is incorrect" });

            return Ok(response);
        }

        [HttpPost("GoogleSaveUser")]
        public ActionResult GoogleSavePassenger(SaveUser model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_saveGoogleUser",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e.Message);
            }   
        }

        // [HttpPost("saveWebUser")]
        // public IActionResult saveWebUser(MobileUserCreation model)
        // {
        //     try
        //     {
        //         var response = dapperQuery.SPReturn("sp_saveUser",model,_dbCon);

        //         if (response.Contains("Success"))
        //         {
        //             return Ok(response);
        //         }
        //         else
        //         {
        //             return BadRequest(response);
        //         }

        //     }
        //     catch(Exception e)
        //     {
        //         return BadRequest(e);
        //     }
        // }
        // with google 
        [HttpPost("LoginGoogleAuth")]
        public IActionResult LoginGoogleAuth(GoogleAuthenticateRequest model)
        {
            try
            {

            
            var response = _userService.GoogleLoginAuthenticate(model);
            if (response == null)
                return BadRequest(new { message = "user name or password is incorrect" });

            return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpGet("getUserInfo")]
        public IActionResult getUserInfo(int userID)
        {
            try
            {
                cmd = "select * from view_userInfo where userID="+userID+"";
                var appMenu = dapperQuery.Qry<UserInfo>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpPost("saveWebUser")]
        public IActionResult saveWebUser(MobileUserCreation model)
        {
            try
            {
                model.eDocPath = "C:\\inetpub\\wwwroot\\CSS-Portal\\CSS-Portal-app\\browser\\assets\\Applicant-images\\Applicant-Profile";
                var response = dapperQuery.SPReturn("sp_saveUser", model, _dbCon);
                var data = response.Select(row => new { res = row.ToString() });
                bool result = data.First().res.Contains("Success");

                if (result == true && (string.IsNullOrEmpty(model.eDocPath) && string.IsNullOrEmpty(model.eDocPath) && string.IsNullOrEmpty(model.eDocPath)))
                {
                    var userID = data.First().res.Split("|||")[1];
                    dapperQuery.saveImageFile(
                        model.eDocPath,
                        userID,
                        model.eDoc,
                        model.eDocExt);
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpPost("saveUserAcademicInfo")]
        public IActionResult saveUserAcademicInfo(UserAcadmicInfo model)
        {
            try
            {
                 model.eResumePath = "C:\\inetpub\\wwwroot\\CSS-Portal\\CSS-Portal-app\\browser\\assets\\Applicant-images\\Applicant-resume";
                var response = dapperQuery.SPReturn("sp_saveUserAcadmicInfo", model, _dbCon);
                var data = response.Select(row => new { res = row.ToString() });
                bool result = data.First().res.Contains("Success");
               // var response = dapperQuery.SPReturn("sp_saveUserAcadmicInfo",model,_dbCon);
               
                if (result == true && (string.IsNullOrEmpty(model.eResumePath) && string.IsNullOrEmpty(model.eResumePath) && string.IsNullOrEmpty(model.eResumePath)))
                {
                    var userID = data.First().res.Split("|||")[1];
                    dapperQuery.saveImageFile(
                        model.eResumePath,
                        userID,
                        model.eResume,
                        model.eResumeExt);
                }
                return Ok(response);

            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost("saveUserInterestInfo")]
        public ActionResult saveUserInterestInfo(SaveUserInterest model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_saveUserInterest",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e.Message);
            }   
        }
        [HttpGet("getVerifyOTP")]
        public IActionResult getVerifyOTP(string OTP)
        {
            try
            {
                cmd = "SELECT otpNo from OTP where otpNo = '" + OTP + "' ";
                var appMenu = dapperQuery.Qry<OTP>(cmd, _dbCon);
                if (appMenu == null || !appMenu.Any())
                {
                    return BadRequest(appMenu);
                }
                else
                {
                    return Ok(appMenu);    
                }
                
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPost("getOTP")]
        public IActionResult getOTP(SendEmail obj)
        {
            try
            {
            DateTime curDate = DateTime.Today;
            DateTime curTime = DateTime.Now;
            
            var time = curTime.ToString("HH:mm");
            Random rnd = new Random();
            randomNumber = (rnd.Next(1000,9999)).ToString();
            
            // int rowAffected = 0;
            var response = "";
            var newOTPid = 0;
            var newUserID = 0;
            List<userDetail> appMenuUserEmail = new List<userDetail>();
            cmd3 = "select TOP 1 userID from tbl_user where email = '" + obj.email + "' ";
            appMenuUserEmail = (List<userDetail>)dapperQuery.Qry<userDetail>(cmd3, _dbCon);

            if (appMenuUserEmail.Count > 0)
            {
                newUserID = appMenuUserEmail[0].userID;
            }

            if (newUserID > 0)
            {
            
                List<OTP> appMenuUserID = new List<OTP>();
                cmd3 = "select TOP 1 otpID from OTP ORDER BY otpID DESC";
                appMenuUserID = (List<OTP>)dapperQuery.Qry<OTP>(cmd3, _dbCon);

                if(appMenuUserID.Count == 0)
                    {
                        newOTPid = 1;    
                    }else{
                        newOTPid = appMenuUserID[0].otpID+1;
                    }
                    // cmd2 = "";
                    // rowAffected = dapperQuery.Qry<OTP>(cmd2, _dbCon);
                    cmd2 = "insert into OTP (otpID,otpNo,timestamp) values (" + newOTPid + ",'" + randomNumber + "', getdate())";
                    var appMenu = dapperQuery.Qry<OTP>(cmd2, _dbCon);

                    
                        
                        using (MailMessage mail = new MailMessage())
                            {
                                mail.From = new MailAddress("noreply@mysite.com");
                                mail.To.Add(obj.email);
                                mail.Subject = "Your one time password for verification";
                                mail.Body = "your one time password is "+ randomNumber +".";
                                mail.IsBodyHtml = true;

                                //* for setting smtp mail name and port
                                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.UseDefaultCredentials = false;
                                    //* for setting sender credentials(email and password) using smtp
                                    smtp.Credentials = new System.Net.NetworkCredential("hammadhere12@gmail.com","kzmbylxeaunvfytb");
                                    smtp.EnableSsl = true;
                                    
                                    smtp.Send(mail);
                                }
                            }
                            
                        response = "Mail Sent!";
                        return Ok(new { message = response });
            }
            else
            {
                response = "Please enter valid email address";
                return BadRequest(new { message = response });
            }
                // }
                // else
                // {
                    
                //     response = "Something went wrong";
                //     return BadRequest(new { message = response });

                // }

            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }   
        }

        [HttpPost("forgetPassword")]
        public IActionResult forgetPassword(UpdatePassword model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_password_update",model,_dbCon);
                return Ok(response);

            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

        [HttpPost("saveUserBranch")]
        public IActionResult saveUserBranch(UserBranchCreation model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_userBranchesCrud",model,_dbCon);

                return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpGet("genToken")]
        public IActionResult genToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("userLoginId", "1") }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key)
                ,SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);
            return Ok(new {message = tokenHandler.WriteToken(token)});
        }
        [HttpGet("getPartyID")]
        public IActionResult getPartyID(int userID)
        {
            try
            {
                cmd = "select distinct * from view_getPartyID where userID="+userID+"";
                var appMenu = dapperQuery.Qry<GetParty>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

    }
}