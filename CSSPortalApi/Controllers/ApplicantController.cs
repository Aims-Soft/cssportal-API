using System;
using Microsoft.AspNetCore.Mvc;
using CSSPortalApi.Services;
using CSSPortalApi.Entities;
using Microsoft.Extensions.Options;
using CSSPortalApi.Configuration;

namespace CSSPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ApplicantController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public ApplicantController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getAppliedSession")]
    public IActionResult getAppliedSession(int userID)
    {
        try
        {
            cmd = "select * from view_getAppliedSession where userID= "+userID+"";
            var response = dapperQuery.Qry<AppliedSession>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getUserSessions")]
    public IActionResult getUserSessions(int userID)
    {
        try
        {
            cmd = "select * from view_getUserSession where userID= "+userID+"";
            var response = dapperQuery.Qry<UserSession>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getUserSessionsCount")]
    public IActionResult getUserSessionsCount(int userID)
    {
        try
        {
            cmd = "select * from view_userSessionCount where userID= "+userID+"";
            var response = dapperQuery.Qry<SessionCount>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("saveApplicantSession")]
    public IActionResult saveApplicantSession(ApplicantSession model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveApplicantSession", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
}