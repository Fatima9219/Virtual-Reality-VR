using System;
using System.ComponentModel.DataAnnotations;

namespace BDGLS.Models
{
	/// <summary>
	/// New User Record Model
	/// </summary>
	public class UserModel
	{
		[Key]
		public Guid UUID { get; set; }

		[Required(ErrorMessage = "Username is required")]
		public string Username { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public byte[] Image { get; set; }
				
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}

	/// <summary>
	/// Response User Profile Model
	/// </summary>
	public class Profile
	{
		public string Username { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }		
		public byte[] Image { get; set; }
	}
}


/// associated table

/*
CREATE TABLE public."User"  
(    
  "UUID"			UUID         NOT NULL,
  "Username"		VARCHAR(16)  NOT NULL,
  "Firstname"		VARCHAR(32)  NOT NULL,
  "Lastname"		VARCHAR(32)  NOT NULL,
  "Image"			BYTEA,
  "Password"		VARCHAR(128) NOT NULL,
  CONSTRAINT user_pkey PRIMARY KEY ("UUID")
);

ALTER TABLE public."User"
  OWNER TO postgres; 
 */


/* Example

POST   https://localhost:5001/api/User/Create

{
    "Username" :"MyUsername",
    "Firstname":"MyFirstname",
    "Lastname" :"MyLastname",
    "Password" :"MyP@ssword"
} 
 */