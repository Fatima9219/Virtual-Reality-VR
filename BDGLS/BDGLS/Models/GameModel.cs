using System.ComponentModel.DataAnnotations;

// General model for applications
namespace BDGLS.Models
{
	public class GameModel
	{
		[Key]
		public System.Guid UUID { get; set; }

		public byte[] Data { get; set; }
	}
}

/// associated table
/*

CREATE TABLE public."MyAppName"
(
  "UUID"		UUID		NOT NULL,
  "Data"		BYTEA		NOT NULL,
  PRIMARY KEY("UUID")
);

ALTER TABLE public."MyAppName"
  OWNER TO postgres;

*/