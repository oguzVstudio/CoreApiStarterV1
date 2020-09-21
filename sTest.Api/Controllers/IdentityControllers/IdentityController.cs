using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sTest.Api.Contracts_Routes_.v1;
using sTest.Api.Requests.Version1.ApiLogin;
using sTest.Api.Responses.Version1.ApiLogin;
using sTest.BusinessLogic.Interfaces;

namespace sTest.Api.Controllers.IdentityControllers
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService) => this._identityService = identityService;
        /// <summary>
        /// User registration from db and get tokenKey
        /// </summary>
        /// <response code="200">User registration and get tokenKey successfull</response>
        /// <response code="400">UserName or Password incorrect</response>
        [HttpPost(ApiRoutes.Identity.Register)]
        [ProducesResponseType(type: typeof(ApiAuthSuccessResponse), statusCode: 200)]
        [ProducesResponseType(type: typeof(ApiAuthFailedResponse), statusCode: 400)]
        public async Task<IActionResult> Register([FromBody] ApiUserRegistrationRequest userRegistrationRequest)
        {
            var authResponse = await
                _identityService.RegisterAsync(
                    userName: userRegistrationRequest.UserName,
                    password: userRegistrationRequest.Password,
                    firstName: userRegistrationRequest.FirstName,
                    lastName: userRegistrationRequest.LastName,
                    email: userRegistrationRequest.Email,
                    phoneNumber: userRegistrationRequest.PhoneNumber
                );

            if (!authResponse.Success)
            {
                return BadRequest(error: new ApiAuthFailedResponse
                {
                    Errors = authResponse.Errors
                }
                );
            }

            return Ok(value: new ApiAuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }


        /// <summary>
        /// Get token by username and password
        /// </summary>
        /// <response code="200">Get tokenKey successfuly</response>
        /// <response code="400">UserName or Password incorrect</response>
        [HttpPost(ApiRoutes.Identity.Login)]
        [ProducesResponseType(type: typeof(ApiAuthSuccessResponse), statusCode: 200)]
        [ProducesResponseType(type: typeof(ApiAuthFailedResponse), statusCode: 400)]
        public async Task<IActionResult> Login([FromBody] ApiUserLoginRequest userLoginRequest)
        {
            var authResponse = await
                _identityService.LoginAsync(userName: userLoginRequest.UserName, password: userLoginRequest.Password);

            if (!authResponse.Success)
            {
                return BadRequest(error: new ApiAuthFailedResponse
                {
                    Errors = authResponse.Errors
                }
                );
            }

            return Ok(value: new ApiAuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }


        /// <summary>
        /// Get token by refreshToken
        /// </summary>
        /// <response code="200">Get tokenKey successfuly</response>
        /// <response code="400">UserName or Password incorrect</response>
        [HttpPost(ApiRoutes.Identity.Refresh)]
        [ProducesResponseType(type: typeof(ApiAuthSuccessResponse), statusCode: 200)]
        [ProducesResponseType(type: typeof(ApiAuthFailedResponse), statusCode: 400)]
        public async Task<IActionResult> Refresh([FromBody] ApiRefreshTokenRequest refreshTokenRequest)
        {
            var authResponse = await
                _identityService.RefreshTokenAsync(token: refreshTokenRequest.Token,
                    refreshToken: refreshTokenRequest.RefreshToken);

            if (!authResponse.Success)
            {
                return BadRequest(error: new ApiAuthFailedResponse
                {
                    Errors = authResponse.Errors
                }
                );
            }

            return Ok(value: new ApiAuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }
    }
}
