using System;
using Microsoft.AspNetCore.Mvc;
using CSSPortalApi.Services;
using CSSPortalApi.Entities;
using Microsoft.Extensions.Options;
using CSSPortalApi.Configuration;

namespace CSSPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class TrainerController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public TrainerController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getCity")]
    public IActionResult getCity()
    {
        try
        {
            cmd = "select cityID,cityName,countryID from tbl_city where isdeleted=0";
            var response = dapperQuery.Qry<GetCity>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCountry")]
    public IActionResult getCountry()
    {
        try
        {
            cmd = "select countryID,countryName from tbl_country where isdeleted=0";
            var response = dapperQuery.Qry<GetCountry>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getGender")]
    public IActionResult getGender()
    {
        try
        {
            cmd = "select * from tbl_gender";
            var response = dapperQuery.Qry<GetGender>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getTrainerDetail")]
    public IActionResult getTrainerDetail(int userID)
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
    [HttpGet("getAssignedSessions")]
    public IActionResult getAssignedSessions(int userID)
    {
        try
        {
            cmd = "select * from view_assignedSessions where userID = " + userID + "";
            var appMenu = dapperQuery.Qry<AssignedSessions>(cmd, _dbCon);
            return Ok(appMenu);
        }
        catch(Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpGet("getTodaySessions")]
    public IActionResult getTodaySessions(int userID)
    {
        try
        {
            cmd = "select * from view_assignedSessions where userID = " + userID + " and  CAST([date] AS DATE) >= CAST(GETDATE() AS DATE)";
            var appMenu = dapperQuery.Qry<AssignedSessions>(cmd, _dbCon);
            return Ok(appMenu);
        }
        catch(Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpGet("getApplicant")]
    public IActionResult getApplicant(int sessionID)
    {
        try
        {
            cmd = "select * from view_getApplicant where sessionID = " + sessionID + "";
            var appMenu = dapperQuery.Qry<GetUser>(cmd, _dbCon);
            return Ok(appMenu);
        }
        catch(Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpGet("getTrainerSessionCount")]
    public IActionResult getTrainerSessionCount(int userID)
    {
        try
        {
            cmd = "select * from view_TrainerSessionCount where userID = " + userID + "";
            var appMenu = dapperQuery.Qry<TrainerSessionCount>(cmd, _dbCon);
            return Ok(appMenu);
        }
        catch(Exception e)
        {
            return Ok(e.Message);
        }
    }// last
    // [HttpPost("updateTrainer")]
    //     public IActionResult updateTrainer(UpdateTrainer model)
    //     {
    //         try
    //         {
    //             model.eDocPath = "C:\\inetpub\\wwwroot\\YouthPortal\\YouthPortal-app\\assets\\Trainer-images\\Trainer-Profile";
    //             var response = dapperQuery.SPReturn("sp_updateTrainer", model, _dbCon);
    //             var data = response.Select(row => new { res = row.ToString() });
    //             bool result = data.First().res.Contains("Success");

    //             if (result == true && (string.IsNullOrEmpty(model.eDoc) && string.IsNullOrEmpty(model.eDocPath) && string.IsNullOrEmpty(model.eDoc)))
    //             {
    //                 var userID = data.First().res.Split("|||")[1];
    //                 dapperQuery.saveImageFile(
    //                     model.eDocPath,
    //                     userID,
    //                     model.eDoc,
    //                     model.eDocExt);
    //             }
    //             return Ok(response);
    //         }
    //         catch (Exception e)
    //         {
    //             return Ok(e.Message);
    //         }
    //     }
    [HttpPost("updateTrainer")]
public IActionResult updateTrainer(UpdateTrainer model)
{
    try
    {
        model.eDocPath = @"C:\\inetpub\\wwwroot\\YouthPortal\\YouthPortal-app\\browser\\assets\\Trainer-images\\Trainer-Profile";

        var response = dapperQuery.SPReturn("sp_updateTrainer", model, _dbCon);
        var data = response.Select(row => new { res = row.ToString() }).FirstOrDefault();

        if (data != null && data.res.Contains("Success"))
        {
            var userID = data.res.Split("|||")[1];

            if (!string.IsNullOrEmpty(model.eDoc) && !string.IsNullOrEmpty(model.eDocExt))
            {
                // Ensure folder exists
                if (!Directory.Exists(model.eDocPath))
                {
                    Directory.CreateDirectory(model.eDocPath);
                }

                dapperQuery.saveImageFile(
                    model.eDocPath,
                    userID,
                    model.eDoc,
                    model.eDocExt
                );
            }
        }

        return Ok(response);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}
    [HttpPost("saveTrainerExperience")]
    public IActionResult saveTrainerExperience(TrainerExperience model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_trainerInterestExp", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveSessionStatus")]
    public IActionResult saveSessionStatus(SessionStatusChange model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_sessionStatus", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveAttanedSession")]
    public IActionResult saveAttanedSession(SessionAttend model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_attendSession", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }

}