/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/30/2012 5:12:47 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSLibrarianDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LibrarianDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _lbId;
	private System.Int64? _lbLoginID;
	private System.Int64? _lbUsertype;
	private System.String _lbFirstName;
	private System.String _lbMiddleName;
	private System.String _lbLastName;
	private System.String _lbPhoto;
	private System.DateTime? _lbDob;
	private System.String _lbCaste;
	private System.String _lbSubCaste;
	private System.String _lbBirthPlace;
	private System.String _lbGender;
	private System.String _lbBloodGroup;
	private System.String _lbMotherTongue;
	private System.DateTime? _lbDoj;
	private System.String _lbHighestDegree;
	private System.String _lbCompletedYear;
	private System.String _lbUniversity;
	private System.Int64? _lbAddressId;
	private System.String _lbAgeproof;
	private System.String _lbReleavingLetter;
	private System.String _lbResume;
	private System.Int32? _lbStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LbId
	{
		get
		{
			return _lbId;
		}
		set
		{
			_lbId = value;
		}
	}
	
	public System.Int64? LBLoginID
	{
		get
		{
			return _lbLoginID;
		}
		set
		{
			_lbLoginID = value;
		}
	}
	
	public System.Int64? LBUsertype
	{
		get
		{
			return _lbUsertype;
		}
		set
		{
			_lbUsertype = value;
		}
	}
	
	public System.String LBFirstName
	{
		get
		{
			return _lbFirstName;
		}
		set
		{
			_lbFirstName = value;
		}
	}
	
	public System.String LBMiddleName
	{
		get
		{
			return _lbMiddleName;
		}
		set
		{
			_lbMiddleName = value;
		}
	}
	
	public System.String LBLastName
	{
		get
		{
			return _lbLastName;
		}
		set
		{
			_lbLastName = value;
		}
	}
	
	public System.String LBPhoto
	{
		get
		{
			return _lbPhoto;
		}
		set
		{
			_lbPhoto = value;
		}
	}
	
	public System.DateTime? LbDob
	{
		get
		{
			return _lbDob;
		}
		set
		{
			_lbDob = value;
		}
	}
	
	public System.String LBCaste
	{
		get
		{
			return _lbCaste;
		}
		set
		{
			_lbCaste = value;
		}
	}
	
	public System.String LBSubCaste
	{
		get
		{
			return _lbSubCaste;
		}
		set
		{
			_lbSubCaste = value;
		}
	}
	
	public System.String LBBirthPlace
	{
		get
		{
			return _lbBirthPlace;
		}
		set
		{
			_lbBirthPlace = value;
		}
	}
	
	public System.String LBGender
	{
		get
		{
			return _lbGender;
		}
		set
		{
			_lbGender = value;
		}
	}
	
	public System.String LBBloodGroup
	{
		get
		{
			return _lbBloodGroup;
		}
		set
		{
			_lbBloodGroup = value;
		}
	}
	
	public System.String LBMotherTongue
	{
		get
		{
			return _lbMotherTongue;
		}
		set
		{
			_lbMotherTongue = value;
		}
	}
	
	public System.DateTime? LbDoj
	{
		get
		{
			return _lbDoj;
		}
		set
		{
			_lbDoj = value;
		}
	}
	
	public System.String LBHighestDegree
	{
		get
		{
			return _lbHighestDegree;
		}
		set
		{
			_lbHighestDegree = value;
		}
	}
	
	public System.String LBCompletedYear
	{
		get
		{
			return _lbCompletedYear;
		}
		set
		{
			_lbCompletedYear = value;
		}
	}
	
	public System.String LBUniversity
	{
		get
		{
			return _lbUniversity;
		}
		set
		{
			_lbUniversity = value;
		}
	}
	
	public System.Int64? LBAddressId
	{
		get
		{
			return _lbAddressId;
		}
		set
		{
			_lbAddressId = value;
		}
	}
	
	public System.String LBAgeproof
	{
		get
		{
			return _lbAgeproof;
		}
		set
		{
			_lbAgeproof = value;
		}
	}
	
	public System.String LBReleavingLetter
	{
		get
		{
			return _lbReleavingLetter;
		}
		set
		{
			_lbReleavingLetter = value;
		}
	}
	
	public System.String LBResume
	{
		get
		{
			return _lbResume;
		}
		set
		{
			_lbResume = value;
		}
	}
	
	public System.Int32? LBStatus
	{
		get
		{
			return _lbStatus;
		}
		set
		{
			_lbStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("LB_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_LoginID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Usertype", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Photo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_DOB", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Caste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_SubCaste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_BirthPlace", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Gender", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_BloodGroup", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_MotherTongue", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_DOJ", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_HighestDegree", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_CompletedYear", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_University", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Ageproof", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_ReleavingLetter", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Resume", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LB_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LbId == null)
		dr["LB_ID"] = DBNull.Value;
		else
		dr["LB_ID"] = LbId;
		
		if (LBLoginID == null)
		dr["LB_LoginID"] = DBNull.Value;
		else
		dr["LB_LoginID"] = LBLoginID;
		
		if (LBUsertype == null)
		dr["LB_Usertype"] = DBNull.Value;
		else
		dr["LB_Usertype"] = LBUsertype;
		
		if (LBFirstName == null)
		dr["LB_FirstName"] = DBNull.Value;
		else
		dr["LB_FirstName"] = LBFirstName;
		
		if (LBMiddleName == null)
		dr["LB_MiddleName"] = DBNull.Value;
		else
		dr["LB_MiddleName"] = LBMiddleName;
		
		if (LBLastName == null)
		dr["LB_LastName"] = DBNull.Value;
		else
		dr["LB_LastName"] = LBLastName;
		
		if (LBPhoto == null)
		dr["LB_Photo"] = DBNull.Value;
		else
		dr["LB_Photo"] = LBPhoto;
		
		if (LbDob == null)
		dr["LB_DOB"] = DBNull.Value;
		else
		dr["LB_DOB"] = LbDob;
		
		if (LBCaste == null)
		dr["LB_Caste"] = DBNull.Value;
		else
		dr["LB_Caste"] = LBCaste;
		
		if (LBSubCaste == null)
		dr["LB_SubCaste"] = DBNull.Value;
		else
		dr["LB_SubCaste"] = LBSubCaste;
		
		if (LBBirthPlace == null)
		dr["LB_BirthPlace"] = DBNull.Value;
		else
		dr["LB_BirthPlace"] = LBBirthPlace;
		
		if (LBGender == null)
		dr["LB_Gender"] = DBNull.Value;
		else
		dr["LB_Gender"] = LBGender;
		
		if (LBBloodGroup == null)
		dr["LB_BloodGroup"] = DBNull.Value;
		else
		dr["LB_BloodGroup"] = LBBloodGroup;
		
		if (LBMotherTongue == null)
		dr["LB_MotherTongue"] = DBNull.Value;
		else
		dr["LB_MotherTongue"] = LBMotherTongue;
		
		if (LbDoj == null)
		dr["LB_DOJ"] = DBNull.Value;
		else
		dr["LB_DOJ"] = LbDoj;
		
		if (LBHighestDegree == null)
		dr["LB_HighestDegree"] = DBNull.Value;
		else
		dr["LB_HighestDegree"] = LBHighestDegree;
		
		if (LBCompletedYear == null)
		dr["LB_CompletedYear"] = DBNull.Value;
		else
		dr["LB_CompletedYear"] = LBCompletedYear;
		
		if (LBUniversity == null)
		dr["LB_University"] = DBNull.Value;
		else
		dr["LB_University"] = LBUniversity;
		
		if (LBAddressId == null)
		dr["LB_AddressId"] = DBNull.Value;
		else
		dr["LB_AddressId"] = LBAddressId;
		
		if (LBAgeproof == null)
		dr["LB_Ageproof"] = DBNull.Value;
		else
		dr["LB_Ageproof"] = LBAgeproof;
		
		if (LBReleavingLetter == null)
		dr["LB_ReleavingLetter"] = DBNull.Value;
		else
		dr["LB_ReleavingLetter"] = LBReleavingLetter;
		
		if (LBResume == null)
		dr["LB_Resume"] = DBNull.Value;
		else
		dr["LB_Resume"] = LBResume;
		
		if (LBStatus == null)
		dr["LB_Status"] = DBNull.Value;
		else
		dr["LB_Status"] = LBStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LbId = dr["LB_ID"] != DBNull.Value ? Convert.ToInt64(dr["LB_ID"]) : LbId = null;
		LBLoginID = dr["LB_LoginID"] != DBNull.Value ? Convert.ToInt64(dr["LB_LoginID"]) : LBLoginID = null;
		LBUsertype = dr["LB_Usertype"] != DBNull.Value ? Convert.ToInt64(dr["LB_Usertype"]) : LBUsertype = null;
		LBFirstName = dr["LB_FirstName"] != DBNull.Value ? Convert.ToString(dr["LB_FirstName"]) : LBFirstName = null;
		LBMiddleName = dr["LB_MiddleName"] != DBNull.Value ? Convert.ToString(dr["LB_MiddleName"]) : LBMiddleName = null;
		LBLastName = dr["LB_LastName"] != DBNull.Value ? Convert.ToString(dr["LB_LastName"]) : LBLastName = null;
		LBPhoto = dr["LB_Photo"] != DBNull.Value ? Convert.ToString(dr["LB_Photo"]) : LBPhoto = null;
		LbDob = dr["LB_DOB"] != DBNull.Value ? Convert.ToDateTime(dr["LB_DOB"]) : LbDob = null;
		LBCaste = dr["LB_Caste"] != DBNull.Value ? Convert.ToString(dr["LB_Caste"]) : LBCaste = null;
		LBSubCaste = dr["LB_SubCaste"] != DBNull.Value ? Convert.ToString(dr["LB_SubCaste"]) : LBSubCaste = null;
		LBBirthPlace = dr["LB_BirthPlace"] != DBNull.Value ? Convert.ToString(dr["LB_BirthPlace"]) : LBBirthPlace = null;
		LBGender = dr["LB_Gender"] != DBNull.Value ? Convert.ToString(dr["LB_Gender"]) : LBGender = null;
		LBBloodGroup = dr["LB_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["LB_BloodGroup"]) : LBBloodGroup = null;
		LBMotherTongue = dr["LB_MotherTongue"] != DBNull.Value ? Convert.ToString(dr["LB_MotherTongue"]) : LBMotherTongue = null;
		LbDoj = dr["LB_DOJ"] != DBNull.Value ? Convert.ToDateTime(dr["LB_DOJ"]) : LbDoj = null;
		LBHighestDegree = dr["LB_HighestDegree"] != DBNull.Value ? Convert.ToString(dr["LB_HighestDegree"]) : LBHighestDegree = null;
		LBCompletedYear = dr["LB_CompletedYear"] != DBNull.Value ? Convert.ToString(dr["LB_CompletedYear"]) : LBCompletedYear = null;
		LBUniversity = dr["LB_University"] != DBNull.Value ? Convert.ToString(dr["LB_University"]) : LBUniversity = null;
		LBAddressId = dr["LB_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["LB_AddressId"]) : LBAddressId = null;
		LBAgeproof = dr["LB_Ageproof"] != DBNull.Value ? Convert.ToString(dr["LB_Ageproof"]) : LBAgeproof = null;
		LBReleavingLetter = dr["LB_ReleavingLetter"] != DBNull.Value ? Convert.ToString(dr["LB_ReleavingLetter"]) : LBReleavingLetter = null;
		LBResume = dr["LB_Resume"] != DBNull.Value ? Convert.ToString(dr["LB_Resume"]) : LBResume = null;
		LBStatus = dr["LB_Status"] != DBNull.Value ? Convert.ToInt32(dr["LB_Status"]) : LBStatus = null;
	}
	
	public static TMSLibrarianDetails[] MapFrom(DataSet ds)
	{
		List<TMSLibrarianDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLibrarianDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LibrarianDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LibrarianDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLibrarianDetails instance = new TMSLibrarianDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrarianDetails Get(System.Int64 lbId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLibrarianDetails instance;
		
		
		instance = new TMSLibrarianDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lbId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLibrarianDetails ID:" + lbId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lbLoginID, lbUsertype, lbFirstName, lbMiddleName, lbLastName, lbPhoto, lbDob, lbCaste, lbSubCaste, lbBirthPlace, lbGender, lbBloodGroup, lbMotherTongue, lbDoj, lbHighestDegree, lbCompletedYear, lbUniversity, lbAddressId, lbAgeproof, lbReleavingLetter, lbResume, lbStatus);
		
		if (transaction == null)
		this.LbId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LbId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus)
	{
		Insert(lbLoginID, lbUsertype, lbFirstName, lbMiddleName, lbLastName, lbPhoto, lbDob, lbCaste, lbSubCaste, lbBirthPlace, lbGender, lbBloodGroup, lbMotherTongue, lbDoj, lbHighestDegree, lbCompletedYear, lbUniversity, lbAddressId, lbAgeproof, lbReleavingLetter, lbResume, lbStatus, null);
	}
	/// <summary>
	/// Insert current TMSLibrarianDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LBLoginID, LBUsertype, LBFirstName, LBMiddleName, LBLastName, LBPhoto, LbDob, LBCaste, LBSubCaste, LBBirthPlace, LBGender, LBBloodGroup, LBMotherTongue, LbDoj, LBHighestDegree, LBCompletedYear, LBUniversity, LBAddressId, LBAgeproof, LBReleavingLetter, LBResume, LBStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLibrarianDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? lbId, System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@lbId"].Value = lbId;
		dbCommand.Parameters["@lbLoginID"].Value = lbLoginID;
		dbCommand.Parameters["@lbUsertype"].Value = lbUsertype;
		dbCommand.Parameters["@lbFirstName"].Value = lbFirstName;
		dbCommand.Parameters["@lbMiddleName"].Value = lbMiddleName;
		dbCommand.Parameters["@lbLastName"].Value = lbLastName;
		dbCommand.Parameters["@lbPhoto"].Value = lbPhoto;
		dbCommand.Parameters["@lbDob"].Value = lbDob;
		dbCommand.Parameters["@lbCaste"].Value = lbCaste;
		dbCommand.Parameters["@lbSubCaste"].Value = lbSubCaste;
		dbCommand.Parameters["@lbBirthPlace"].Value = lbBirthPlace;
		dbCommand.Parameters["@lbGender"].Value = lbGender;
		dbCommand.Parameters["@lbBloodGroup"].Value = lbBloodGroup;
		dbCommand.Parameters["@lbMotherTongue"].Value = lbMotherTongue;
		dbCommand.Parameters["@lbDoj"].Value = lbDoj;
		dbCommand.Parameters["@lbHighestDegree"].Value = lbHighestDegree;
		dbCommand.Parameters["@lbCompletedYear"].Value = lbCompletedYear;
		dbCommand.Parameters["@lbUniversity"].Value = lbUniversity;
		dbCommand.Parameters["@lbAddressId"].Value = lbAddressId;
		dbCommand.Parameters["@lbAgeproof"].Value = lbAgeproof;
		dbCommand.Parameters["@lbReleavingLetter"].Value = lbReleavingLetter;
		dbCommand.Parameters["@lbResume"].Value = lbResume;
		dbCommand.Parameters["@lbStatus"].Value = lbStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? lbId, System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus)
	{
		Update(lbId, lbLoginID, lbUsertype, lbFirstName, lbMiddleName, lbLastName, lbPhoto, lbDob, lbCaste, lbSubCaste, lbBirthPlace, lbGender, lbBloodGroup, lbMotherTongue, lbDoj, lbHighestDegree, lbCompletedYear, lbUniversity, lbAddressId, lbAgeproof, lbReleavingLetter, lbResume, lbStatus, null);
	}
	
	public static void Update(TMSLibrarianDetails tMSLibrarianDetails)
	{
		tMSLibrarianDetails.Update();
	}
	
	public static void Update(TMSLibrarianDetails tMSLibrarianDetails, DbTransaction transaction)
	{
		tMSLibrarianDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@lbId"].SourceColumn = "LB_ID";
		dbCommand.Parameters["@lbLoginID"].SourceColumn = "LB_LoginID";
		dbCommand.Parameters["@lbUsertype"].SourceColumn = "LB_Usertype";
		dbCommand.Parameters["@lbFirstName"].SourceColumn = "LB_FirstName";
		dbCommand.Parameters["@lbMiddleName"].SourceColumn = "LB_MiddleName";
		dbCommand.Parameters["@lbLastName"].SourceColumn = "LB_LastName";
		dbCommand.Parameters["@lbPhoto"].SourceColumn = "LB_Photo";
		dbCommand.Parameters["@lbDob"].SourceColumn = "LB_DOB";
		dbCommand.Parameters["@lbCaste"].SourceColumn = "LB_Caste";
		dbCommand.Parameters["@lbSubCaste"].SourceColumn = "LB_SubCaste";
		dbCommand.Parameters["@lbBirthPlace"].SourceColumn = "LB_BirthPlace";
		dbCommand.Parameters["@lbGender"].SourceColumn = "LB_Gender";
		dbCommand.Parameters["@lbBloodGroup"].SourceColumn = "LB_BloodGroup";
		dbCommand.Parameters["@lbMotherTongue"].SourceColumn = "LB_MotherTongue";
		dbCommand.Parameters["@lbDoj"].SourceColumn = "LB_DOJ";
		dbCommand.Parameters["@lbHighestDegree"].SourceColumn = "LB_HighestDegree";
		dbCommand.Parameters["@lbCompletedYear"].SourceColumn = "LB_CompletedYear";
		dbCommand.Parameters["@lbUniversity"].SourceColumn = "LB_University";
		dbCommand.Parameters["@lbAddressId"].SourceColumn = "LB_AddressId";
		dbCommand.Parameters["@lbAgeproof"].SourceColumn = "LB_Ageproof";
		dbCommand.Parameters["@lbReleavingLetter"].SourceColumn = "LB_ReleavingLetter";
		dbCommand.Parameters["@lbResume"].SourceColumn = "LB_Resume";
		dbCommand.Parameters["@lbStatus"].SourceColumn = "LB_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? lbId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lbId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? lbId)
	{
		Delete(
		lbId);
	}
	
	/// <summary>
	/// Delete current TMSLibrarianDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LbId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LbId = null;
	}
	
	/// <summary>
	/// Delete current TMSLibrarianDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrarianDetails[] Search(System.Int64? lbId, System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrarianDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lbId, lbLoginID, lbUsertype, lbFirstName, lbMiddleName, lbLastName, lbPhoto, lbDob, lbCaste, lbSubCaste, lbBirthPlace, lbGender, lbBloodGroup, lbMotherTongue, lbDoj, lbHighestDegree, lbCompletedYear, lbUniversity, lbAddressId, lbAgeproof, lbReleavingLetter, lbResume, lbStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLibrarianDetails.MapFrom(ds);
	}
	
	
	public static TMSLibrarianDetails[] Search(TMSLibrarianDetails searchObject)
	{
		return Search ( searchObject.LbId, searchObject.LBLoginID, searchObject.LBUsertype, searchObject.LBFirstName, searchObject.LBMiddleName, searchObject.LBLastName, searchObject.LBPhoto, searchObject.LbDob, searchObject.LBCaste, searchObject.LBSubCaste, searchObject.LBBirthPlace, searchObject.LBGender, searchObject.LBBloodGroup, searchObject.LBMotherTongue, searchObject.LbDoj, searchObject.LBHighestDegree, searchObject.LBCompletedYear, searchObject.LBUniversity, searchObject.LBAddressId, searchObject.LBAgeproof, searchObject.LBReleavingLetter, searchObject.LBResume, searchObject.LBStatus);
	}
	
	/// <summary>
	/// Returns all TMSLibrarianDetails objects.
	/// </summary>
	/// <returns>List of all TMSLibrarianDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLibrarianDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

