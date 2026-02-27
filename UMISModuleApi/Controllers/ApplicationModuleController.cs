using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using System.Web;
using System.Text.Json.Serialization;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UMISModuleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ApplicationModuleController : ControllerBase
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;

        public ApplicationModuleController(IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
        }

            // [HttpGet("getMenu")]
            // public IActionResult getMenu(string json, int moduleId)
            // {
            //     try
            //     {   
            //         // string formatedJson = HttpUtility.UrlDecode(Request.QueryString[json]);
            //         cmd = "select distinct applicationModuleID,menuId, applicationModuleTitle,menuTitle,moduleIcon,menuIcon, parentRoute, routeTitle,[read], [write], [delete], parentMenuId, menuSeq from view_user_role_details where roleID IN (Select roleID from openJson('"+ json +"') with (roleID INT)) AND applicationModuleID = " + moduleId + " order by menuSeq Asc";
            //         var appMenu = dapperQuery.Qry<Menu>(cmd, _dbCon);
            //         return Ok(appMenu);
            //     }
            //     catch (Exception e)
            //     {
            //         return BadRequest(e.Message);
            //     }

            // }

        [HttpGet("getMenu")]
        public IActionResult getMenu(string json, int moduleId)
        {
            try
            {
                // Decode URL-encoded JSON
                string decodedJson = System.Net.WebUtility.UrlDecode(json);

                // Deserialize JSON into a list of role IDs
                var roles = JsonConvert.DeserializeObject<List<RoleRequest>>(decodedJson);
                var roleIds = roles.Select(r => r.RoleId).ToList();

                // Convert list of role IDs into a comma-separated string (e.g., "3,13,14")
                string roleIdString = string.Join(",", roleIds);

                // Construct SQL query (moduleId is embedded directly)
                string cmd = $@"
                    SELECT DISTINCT applicationModuleID, menuId, applicationModuleTitle, menuTitle, moduleIcon,
                                    menuIcon, parentRoute, routeTitle, [read], [write], [delete], 
                                    parentMenuId, menuSeq
                    FROM view_user_role_details 
                    WHERE roleID IN ({roleIdString}) 
                    AND applicationModuleID = {moduleId} 
                    ORDER BY menuSeq ASC";

                // Call Dapper query (only passing two parameters)
                var appMenu = dapperQuery.Qry<Menu>(cmd, _dbCon);

                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("getMenuById")]
        public IActionResult getMenuById(int applicationModuleID)
        {
            try
            {
                cmd="SELECT * FROM view_menu WHERE applicationModuleID="+applicationModuleID+"";
                var appMenu = dapperQuery.Qry<Menu>(cmd, _dbCon);

                return Ok(appMenu);
            }
            catch(Exception e)
            {
                return Ok(e);
            }
        }

        [HttpGet("getUserModules")]
        public IActionResult getUserModules(int roleId, int userId)
        {
            try
            {
                cmd = "select Distinct applicationModuleID, applicationModuleTitle, moduleIcon from view_user_role_details where roleID = " + roleId + " AND userId = " + userId + ";";
                var appMenu = dapperQuery.Qry<Menu>(cmd, _dbCon);
                return Ok(appMenu);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

    }
}