﻿namespace HotelListing.API.Models.Users
{
    public class AuthResponseDTO
    {
        public string UserID { get; set; }
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}
