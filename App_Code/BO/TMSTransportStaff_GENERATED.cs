/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/29/2012 5:10:13 PM                                    */
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
public partial class TMSTransportStaff
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TransportStaff]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tpId;
	private System.Int64? _tpLoginID;
	private System.Int64? _tpUsertype;
	private System.String _tpFirstName;
	private System.String _tpMiddleName;
	private System.String _tpLastName;
	private System.String _tpPhoto;
	private System.DateTime? _tpDob;
	private System.String _tpCaste;
	private System.String _tpSubCaste;
	private System.String _tpBirthPlace;
	private System.String _tpGender;
	private System.String _tpBloodGroup;
	private System.String _tpMotherTongue;
	private System.DateTime? _tpDoj;
	private System.String _tpHighestDegree;
	private System.String _tpCompletedYear;
	private System.String _tpUniversity;
	private System.Int64? _tpAddressId;
	private System.String _tpAgeproof;
	private System.String _tpReleavingLetter;
	private System.String _tpResume;
	private System.Int32? _tpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TpId
	{
		get
		{
			return _tpId;
		}
		set
		{
			_tpId = value;
		}
	}
	
	public System.Int64? TPLoginID
	{
		get
		{
			return _tpLoginID;
		}
		set
		{
			_tpLoginID = value;
		}
	}
	
	public System.Int64? TPUsertype
	{
		get
		{
			return _tpUsertype;
		}
		set
		{
			_tpUsertype = value;
		}
	}
	
	public System.String TPFirstName
	{
		get
		{
			return _tpFirstName;
		}
		set
		{
			_tpFirstName = value;
		}
	}
	
	public System.String TPMiddleName
	{
		get
		{
			return _tpMiddleName;
		}
		set
		{
			_tpMiddleName = value;
		}
	}
	
	public System.String TPLastName
	{
		get
		{
			return _tpLastName;
		}
		set
		{
			_tpLastName = value;
		}
	}
	
	public System.String TPPhoto
	{
		get
		{
			return _tpPhoto;
		}
		set
		{
			_tpPhoto = value;
		}
	}
	
	public System.DateTime? TpDob
	{
		get
		{
			return _tpDob;
		}
		set
		{
			_tpDob = value;
		}
	}
	
	public System.String TPCaste
	{
		get
		{
			return _tpCaste;
		}
		set
		{
			_tpCaste = value;
		}
	}
	
	public System.String TPSubCaste
	{
		get
		{
			return _tpSubCaste;
		}
		set
		{
			_tpSubCaste = value;
		}
	}
	
	public System.String TPBirthPlace
	{
		get
		{
			return _tpBirthPlace;
		}
		set
		{
			_tpBirthPlace = value;
		}
	}
	
	public System.String TPGender
	{
		get
		{
			return _tpGender;
		}
		set
		{
			_tpGender = value;
		}
	}
	
	public System.String TPBloodGroup
	{
		get
		{
			return _tpBloodGroup;
		}
		set
		{
			_tpBloodGroup = value;
		}
	}
	
	public System.String TPMotherTongue
	{
		get
		{
			return _tpMotherTongue;
		}
		set
		{
			_tpMotherTongue = value;
		}
	}
	
	public System.DateTime? TpDoj
	{
		get
		{
			return _tpDoj;
		}
		set
		{
			_tpDoj = value;
		}
	}
	
	public System.String TPHighestDegree
	{
		get
		{
			return _tpHighestDegree;
		}
		set
		{
			_tpHighestDegree = value;
		}
	}
	
	public System.String TPCompletedYear
	{
		get
		{
			return _tpCompletedYear;
		}
		set
		{
			_tpCompletedYear = value;
		}
	}
	
	public System.String TPUniversity
	{
		get
		{
			return _tpUniversity;
		}
		set
		{
			_tpUniversity = value;
		}
	}
	
	public System.Int64? TPAddressId
	{
		get
		{
			return _tpAddressId;
		}
		set
		{
			_tpAddressId = value;
		}
	}
	
	public System.String TPAgeproof
	{
		get
		{
			return _tpAgeproof;
		}
		set
		{
			_tpAgeproof = value;
		}
	}
	
	public System.String TPReleavingLetter
	{
		get
		{
			return _tpReleavingLetter;
		}
		set
		{
			_tpReleavingLetter = value;
		}
	}
	
	public System.String TPResume
	{
		get
		{
			return _tpResume;
		}
		set
		{
			_tpResume = value;
		}
	}
	
	public System.Int32? TPStatus
	{
		get
		{
			return _tpStatus;
		}
		set
		{
			_tpStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TP_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_LoginID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Usertype", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Photo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_DOB", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Caste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_SubCaste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_BirthPlace", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Gender", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_BloodGroup", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_MotherTongue", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_DOJ", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_HighestDegree", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_CompletedYear", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_University", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Ageproof", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_ReleavingLetter", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Resume", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TP_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TpId == null)
		dr["TP_ID"] = DBNull.Value;
		else
		dr["TP_ID"] = TpId;
		
		if (TPLoginID == null)
		dr["TP_LoginID"] = DBNull.Value;
		else
		dr["TP_LoginID"] = TPLoginID;
		
		if (TPUsertype == null)
		dr["TP_Usertype"] = DBNull.Value;
		else
		dr["TP_Usertype"] = TPUsertype;
		
		if (TPFirstName == null)
		dr["TP_FirstName"] = DBNull.Value;
		else
		dr["TP_FirstName"] = TPFirstName;
		
		if (TPMiddleName == null)
		dr["TP_MiddleName"] = DBNull.Value;
		else
		dr["TP_MiddleName"] = TPMiddleName;
		
		if (TPLastName == null)
		dr["TP_LastName"] = DBNull.Value;
		else
		dr["TP_LastName"] = TPLastName;
		
		if (TPPhoto == null)
		dr["TP_Photo"] = DBNull.Value;
		else
		dr["TP_Photo"] = TPPhoto;
		
		if (TpDob == null)
		dr["TP_DOB"] = DBNull.Value;
		else
		dr["TP_DOB"] = TpDob;
		
		if (TPCaste == null)
		dr["TP_Caste"] = DBNull.Value;
		else
		dr["TP_Caste"] = TPCaste;
		
		if (TPSubCaste == null)
		dr["TP_SubCaste"] = DBNull.Value;
		else
		dr["TP_SubCaste"] = TPSubCaste;
		
		if (TPBirthPlace == null)
		dr["TP_BirthPlace"] = DBNull.Value;
		else
		dr["TP_BirthPlace"] = TPBirthPlace;
		
		if (TPGender == null)
		dr["TP_Gender"] = DBNull.Value;
		else
		dr["TP_Gender"] = TPGender;
		
		if (TPBloodGroup == null)
		dr["TP_BloodGroup"] = DBNull.Value;
		else
		dr["TP_BloodGroup"] = TPBloodGroup;
		
		if (TPMotherTongue == null)
		dr["TP_MotherTongue"] = DBNull.Value;
		else
		dr["TP_MotherTongue"] = TPMotherTongue;
		
		if (TpDoj == null)
		dr["TP_DOJ"] = DBNull.Value;
		else
		dr["TP_DOJ"] = TpDoj;
		
		if (TPHighestDegree == null)
		dr["TP_HighestDegree"] = DBNull.Value;
		else
		dr["TP_HighestDegree"] = TPHighestDegree;
		
		if (TPCompletedYear == null)
		dr["TP_CompletedYear"] = DBNull.Value;
		else
		dr["TP_CompletedYear"] = TPCompletedYear;
		
		if (TPUniversity == null)
		dr["TP_University"] = DBNull.Value;
		else
		dr["TP_University"] = TPUniversity;
		
		if (TPAddressId == null)
		dr["TP_AddressId"] = DBNull.Value;
		else
		dr["TP_AddressId"] = TPAddressId;
		
		if (TPAgeproof == null)
		dr["TP_Ageproof"] = DBNull.Value;
		else
		dr["TP_Ageproof"] = TPAgeproof;
		
		if (TPReleavingLetter == null)
		dr["TP_ReleavingLetter"] = DBNull.Value;
		else
		dr["TP_ReleavingLetter"] = TPReleavingLetter;
		
		if (TPResume == null)
		dr["TP_Resume"] = DBNull.Value;
		else
		dr["TP_Resume"] = TPResume;
		
		if (TPStatus == null)
		dr["TP_Status"] = DBNull.Value;
		else
		dr["TP_Status"] = TPStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TpId = dr["TP_ID"] != DBNull.Value ? Convert.ToInt64(dr["TP_ID"]) : TpId = null;
		TPLoginID = dr["TP_LoginID"] != DBNull.Value ? Convert.ToInt64(dr["TP_LoginID"]) : TPLoginID = null;
		TPUsertype = dr["TP_Usertype"] != DBNull.Value ? Convert.ToInt64(dr["TP_Usertype"]) : TPUsertype = null;
		TPFirstName = dr["TP_FirstName"] != DBNull.Value ? Convert.ToString(dr["TP_FirstName"]) : TPFirstName = null;
		TPMiddleName = dr["TP_MiddleName"] != DBNull.Value ? Convert.ToString(dr["TP_MiddleName"]) : TPMiddleName = null;
		TPLastName = dr["TP_LastName"] != DBNull.Value ? Convert.ToString(dr["TP_LastName"]) : TPLastName = null;
		TPPhoto = dr["TP_Photo"] != DBNull.Value ? Convert.ToString(dr["TP_Photo"]) : TPPhoto = null;
		TpDob = dr["TP_DOB"] != DBNull.Value ? Convert.ToDateTime(dr["TP_DOB"]) : TpDob = null;
		TPCaste = dr["TP_Caste"] != DBNull.Value ? Convert.ToString(dr["TP_Caste"]) : TPCaste = null;
		TPSubCaste = dr["TP_SubCaste"] != DBNull.Value ? Convert.ToString(dr["TP_SubCaste"]) : TPSubCaste = null;
		TPBirthPlace = dr["TP_BirthPlace"] != DBNull.Value ? Convert.ToString(dr["TP_BirthPlace"]) : TPBirthPlace = null;
		TPGender = dr["TP_Gender"] != DBNull.Value ? Convert.ToString(dr["TP_Gender"]) : TPGender = null;
		TPBloodGroup = dr["TP_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["TP_BloodGroup"]) : TPBloodGroup = null;
		TPMotherTongue = dr["TP_MotherTongue"] != DBNull.Value ? Convert.ToString(dr["TP_MotherTongue"]) : TPMotherTongue = null;
		TpDoj = dr["TP_DOJ"] != DBNull.Value ? Convert.ToDateTime(dr["TP_DOJ"]) : TpDoj = null;
		TPHighestDegree = dr["TP_HighestDegree"] != DBNull.Value ? Convert.ToString(dr["TP_HighestDegree"]) : TPHighestDegree = null;
		TPCompletedYear = dr["TP_CompletedYear"] != DBNull.Value ? Convert.ToString(dr["TP_CompletedYear"]) : TPCompletedYear = null;
		TPUniversity = dr["TP_University"] != DBNull.Value ? Convert.ToString(dr["TP_University"]) : TPUniversity = null;
		TPAddressId = dr["TP_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["TP_AddressId"]) : TPAddressId = null;
		TPAgeproof = dr["TP_Ageproof"] != DBNull.Value ? Convert.ToString(dr["TP_Ageproof"]) : TPAgeproof = null;
		TPReleavingLetter = dr["TP_ReleavingLetter"] != DBNull.Value ? Convert.ToString(dr["TP_ReleavingLetter"]) : TPReleavingLetter = null;
		TPResume = dr["TP_Resume"] != DBNull.Value ? Convert.ToString(dr["TP_Resume"]) : TPResume = null;
		TPStatus = dr["TP_Status"] != DBNull.Value ? Convert.ToInt32(dr["TP_Status"]) : TPStatus = null;
	}
	
	public static TMSTransportStaff[] MapFrom(DataSet ds)
	{
		List<TMSTransportStaff> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTransportStaff>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TransportStaff] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TransportStaff] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTransportStaff instance = new TMSTransportStaff();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTransportStaff Get(System.Int64 tpId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTransportStaff instance;
		
		
		instance = new TMSTransportStaff();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tpId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSTransportStaff ID:" + tpId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tpLoginID, tpUsertype, tpFirstName, tpMiddleName, tpLastName, tpPhoto, tpDob, tpCaste, tpSubCaste, tpBirthPlace, tpGender, tpBloodGroup, tpMotherTongue, tpDoj, tpHighestDegree, tpCompletedYear, tpUniversity, tpAddressId, tpAgeproof, tpReleavingLetter, tpResume, tpStatus);
		
		if (transaction == null)
		this.TpId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TpId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus)
	{
		Insert(tpLoginID, tpUsertype, tpFirstName, tpMiddleName, tpLastName, tpPhoto, tpDob, tpCaste, tpSubCaste, tpBirthPlace, tpGender, tpBloodGroup, tpMotherTongue, tpDoj, tpHighestDegree, tpCompletedYear, tpUniversity, tpAddressId, tpAgeproof, tpReleavingLetter, tpResume, tpStatus, null);
	}
	/// <summary>
	/// Insert current TMSTransportStaff to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TPLoginID, TPUsertype, TPFirstName, TPMiddleName, TPLastName, TPPhoto, TpDob, TPCaste, TPSubCaste, TPBirthPlace, TPGender, TPBloodGroup, TPMotherTongue, TpDoj, TPHighestDegree, TPCompletedYear, TPUniversity, TPAddressId, TPAgeproof, TPReleavingLetter, TPResume, TPStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTransportStaff to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tpId, System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tpId"].Value = tpId;
		dbCommand.Parameters["@tpLoginID"].Value = tpLoginID;
		dbCommand.Parameters["@tpUsertype"].Value = tpUsertype;
		dbCommand.Parameters["@tpFirstName"].Value = tpFirstName;
		dbCommand.Parameters["@tpMiddleName"].Value = tpMiddleName;
		dbCommand.Parameters["@tpLastName"].Value = tpLastName;
		dbCommand.Parameters["@tpPhoto"].Value = tpPhoto;
		dbCommand.Parameters["@tpDob"].Value = tpDob;
		dbCommand.Parameters["@tpCaste"].Value = tpCaste;
		dbCommand.Parameters["@tpSubCaste"].Value = tpSubCaste;
		dbCommand.Parameters["@tpBirthPlace"].Value = tpBirthPlace;
		dbCommand.Parameters["@tpGender"].Value = tpGender;
		dbCommand.Parameters["@tpBloodGroup"].Value = tpBloodGroup;
		dbCommand.Parameters["@tpMotherTongue"].Value = tpMotherTongue;
		dbCommand.Parameters["@tpDoj"].Value = tpDoj;
		dbCommand.Parameters["@tpHighestDegree"].Value = tpHighestDegree;
		dbCommand.Parameters["@tpCompletedYear"].Value = tpCompletedYear;
		dbCommand.Parameters["@tpUniversity"].Value = tpUniversity;
		dbCommand.Parameters["@tpAddressId"].Value = tpAddressId;
		dbCommand.Parameters["@tpAgeproof"].Value = tpAgeproof;
		dbCommand.Parameters["@tpReleavingLetter"].Value = tpReleavingLetter;
		dbCommand.Parameters["@tpResume"].Value = tpResume;
		dbCommand.Parameters["@tpStatus"].Value = tpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tpId, System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus)
	{
		Update(tpId, tpLoginID, tpUsertype, tpFirstName, tpMiddleName, tpLastName, tpPhoto, tpDob, tpCaste, tpSubCaste, tpBirthPlace, tpGender, tpBloodGroup, tpMotherTongue, tpDoj, tpHighestDegree, tpCompletedYear, tpUniversity, tpAddressId, tpAgeproof, tpReleavingLetter, tpResume, tpStatus, null);
	}
	
	public static void Update(TMSTransportStaff tMSTransportStaff)
	{
		tMSTransportStaff.Update();
	}
	
	public static void Update(TMSTransportStaff tMSTransportStaff, DbTransaction transaction)
	{
		tMSTransportStaff.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTransportStaff_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tpId"].SourceColumn = "TP_ID";
		dbCommand.Parameters["@tpLoginID"].SourceColumn = "TP_LoginID";
		dbCommand.Parameters["@tpUsertype"].SourceColumn = "TP_Usertype";
		dbCommand.Parameters["@tpFirstName"].SourceColumn = "TP_FirstName";
		dbCommand.Parameters["@tpMiddleName"].SourceColumn = "TP_MiddleName";
		dbCommand.Parameters["@tpLastName"].SourceColumn = "TP_LastName";
		dbCommand.Parameters["@tpPhoto"].SourceColumn = "TP_Photo";
		dbCommand.Parameters["@tpDob"].SourceColumn = "TP_DOB";
		dbCommand.Parameters["@tpCaste"].SourceColumn = "TP_Caste";
		dbCommand.Parameters["@tpSubCaste"].SourceColumn = "TP_SubCaste";
		dbCommand.Parameters["@tpBirthPlace"].SourceColumn = "TP_BirthPlace";
		dbCommand.Parameters["@tpGender"].SourceColumn = "TP_Gender";
		dbCommand.Parameters["@tpBloodGroup"].SourceColumn = "TP_BloodGroup";
		dbCommand.Parameters["@tpMotherTongue"].SourceColumn = "TP_MotherTongue";
		dbCommand.Parameters["@tpDoj"].SourceColumn = "TP_DOJ";
		dbCommand.Parameters["@tpHighestDegree"].SourceColumn = "TP_HighestDegree";
		dbCommand.Parameters["@tpCompletedYear"].SourceColumn = "TP_CompletedYear";
		dbCommand.Parameters["@tpUniversity"].SourceColumn = "TP_University";
		dbCommand.Parameters["@tpAddressId"].SourceColumn = "TP_AddressId";
		dbCommand.Parameters["@tpAgeproof"].SourceColumn = "TP_Ageproof";
		dbCommand.Parameters["@tpReleavingLetter"].SourceColumn = "TP_ReleavingLetter";
		dbCommand.Parameters["@tpResume"].SourceColumn = "TP_Resume";
		dbCommand.Parameters["@tpStatus"].SourceColumn = "TP_Status";
		
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
	public static void Delete(System.Int64? tpId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tpId);
		
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
	public static void Delete(System.Int64? tpId)
	{
		Delete(
		tpId);
	}
	
	/// <summary>
	/// Delete current TMSTransportStaff from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TpId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TpId = null;
	}
	
	/// <summary>
	/// Delete current TMSTransportStaff from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTransportStaff[] Search(System.Int64? tpId, System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTransportStaff_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tpId, tpLoginID, tpUsertype, tpFirstName, tpMiddleName, tpLastName, tpPhoto, tpDob, tpCaste, tpSubCaste, tpBirthPlace, tpGender, tpBloodGroup, tpMotherTongue, tpDoj, tpHighestDegree, tpCompletedYear, tpUniversity, tpAddressId, tpAgeproof, tpReleavingLetter, tpResume, tpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTransportStaff.MapFrom(ds);
	}
	
	
	public static TMSTransportStaff[] Search(TMSTransportStaff searchObject)
	{
		return Search ( searchObject.TpId, searchObject.TPLoginID, searchObject.TPUsertype, searchObject.TPFirstName, searchObject.TPMiddleName, searchObject.TPLastName, searchObject.TPPhoto, searchObject.TpDob, searchObject.TPCaste, searchObject.TPSubCaste, searchObject.TPBirthPlace, searchObject.TPGender, searchObject.TPBloodGroup, searchObject.TPMotherTongue, searchObject.TpDoj, searchObject.TPHighestDegree, searchObject.TPCompletedYear, searchObject.TPUniversity, searchObject.TPAddressId, searchObject.TPAgeproof, searchObject.TPReleavingLetter, searchObject.TPResume, searchObject.TPStatus);
	}
	
	/// <summary>
	/// Returns all TMSTransportStaff objects.
	/// </summary>
	/// <returns>List of all TMSTransportStaff objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTransportStaff[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

