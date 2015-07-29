/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/9/2012 12:10:08 PM                                    */
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
public partial class TMSPrivacySettings
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_PrivacySettings]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _psPrivacyId;
	private System.Int64? _psFacultyLoginId;
	private System.Int64? _psFacultyTypeId;
	private System.String _psFacultyType;
	private System.String _psDisplayPhoto;
	private System.String _psDisplayEducation;
	private System.String _psDisplayConatctDetails;
	private System.String _psDisplayLocation;
	private System.String _psExtraOne;
	private System.String _psExtraTwo;
	private System.String _psExtraThree;
	private System.String _psExtraFour;
	private System.DateTime? _psDate;
	private System.Int32? _psStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PSPrivacyId
	{
		get
		{
			return _psPrivacyId;
		}
		set
		{
			_psPrivacyId = value;
		}
	}
	
	public System.Int64? PSFacultyLoginId
	{
		get
		{
			return _psFacultyLoginId;
		}
		set
		{
			_psFacultyLoginId = value;
		}
	}
	
	public System.Int64? PSFacultyTypeId
	{
		get
		{
			return _psFacultyTypeId;
		}
		set
		{
			_psFacultyTypeId = value;
		}
	}
	
	public System.String PSFacultyType
	{
		get
		{
			return _psFacultyType;
		}
		set
		{
			_psFacultyType = value;
		}
	}
	
	public System.String PSDisplayPhoto
	{
		get
		{
			return _psDisplayPhoto;
		}
		set
		{
			_psDisplayPhoto = value;
		}
	}
	
	public System.String PSDisplayEducation
	{
		get
		{
			return _psDisplayEducation;
		}
		set
		{
			_psDisplayEducation = value;
		}
	}
	
	public System.String PSDisplayConatctDetails
	{
		get
		{
			return _psDisplayConatctDetails;
		}
		set
		{
			_psDisplayConatctDetails = value;
		}
	}
	
	public System.String PSDisplayLocation
	{
		get
		{
			return _psDisplayLocation;
		}
		set
		{
			_psDisplayLocation = value;
		}
	}
	
	public System.String PSExtraOne
	{
		get
		{
			return _psExtraOne;
		}
		set
		{
			_psExtraOne = value;
		}
	}
	
	public System.String PSExtraTwo
	{
		get
		{
			return _psExtraTwo;
		}
		set
		{
			_psExtraTwo = value;
		}
	}
	
	public System.String PSExtraThree
	{
		get
		{
			return _psExtraThree;
		}
		set
		{
			_psExtraThree = value;
		}
	}
	
	public System.String PSExtraFour
	{
		get
		{
			return _psExtraFour;
		}
		set
		{
			_psExtraFour = value;
		}
	}
	
	public System.DateTime? PSDate
	{
		get
		{
			return _psDate;
		}
		set
		{
			_psDate = value;
		}
	}
	
	public System.Int32? PSStatus
	{
		get
		{
			return _psStatus;
		}
		set
		{
			_psStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PS_PrivacyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_FacultyTypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_FacultyType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_DisplayPhoto", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_DisplayEducation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_DisplayConatctDetails", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_DisplayLocation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_ExtraOne", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_ExtraTwo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_ExtraThree", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_ExtraFour", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PSPrivacyId == null)
		dr["PS_PrivacyId"] = DBNull.Value;
		else
		dr["PS_PrivacyId"] = PSPrivacyId;
		
		if (PSFacultyLoginId == null)
		dr["PS_FacultyLoginId"] = DBNull.Value;
		else
		dr["PS_FacultyLoginId"] = PSFacultyLoginId;
		
		if (PSFacultyTypeId == null)
		dr["PS_FacultyTypeId"] = DBNull.Value;
		else
		dr["PS_FacultyTypeId"] = PSFacultyTypeId;
		
		if (PSFacultyType == null)
		dr["PS_FacultyType"] = DBNull.Value;
		else
		dr["PS_FacultyType"] = PSFacultyType;
		
		if (PSDisplayPhoto == null)
		dr["PS_DisplayPhoto"] = DBNull.Value;
		else
		dr["PS_DisplayPhoto"] = PSDisplayPhoto;
		
		if (PSDisplayEducation == null)
		dr["PS_DisplayEducation"] = DBNull.Value;
		else
		dr["PS_DisplayEducation"] = PSDisplayEducation;
		
		if (PSDisplayConatctDetails == null)
		dr["PS_DisplayConatctDetails"] = DBNull.Value;
		else
		dr["PS_DisplayConatctDetails"] = PSDisplayConatctDetails;
		
		if (PSDisplayLocation == null)
		dr["PS_DisplayLocation"] = DBNull.Value;
		else
		dr["PS_DisplayLocation"] = PSDisplayLocation;
		
		if (PSExtraOne == null)
		dr["PS_ExtraOne"] = DBNull.Value;
		else
		dr["PS_ExtraOne"] = PSExtraOne;
		
		if (PSExtraTwo == null)
		dr["PS_ExtraTwo"] = DBNull.Value;
		else
		dr["PS_ExtraTwo"] = PSExtraTwo;
		
		if (PSExtraThree == null)
		dr["PS_ExtraThree"] = DBNull.Value;
		else
		dr["PS_ExtraThree"] = PSExtraThree;
		
		if (PSExtraFour == null)
		dr["PS_ExtraFour"] = DBNull.Value;
		else
		dr["PS_ExtraFour"] = PSExtraFour;
		
		if (PSDate == null)
		dr["PS_Date"] = DBNull.Value;
		else
		dr["PS_Date"] = PSDate;
		
		if (PSStatus == null)
		dr["PS_Status"] = DBNull.Value;
		else
		dr["PS_Status"] = PSStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PSPrivacyId = dr["PS_PrivacyId"] != DBNull.Value ? Convert.ToInt64(dr["PS_PrivacyId"]) : PSPrivacyId = null;
		PSFacultyLoginId = dr["PS_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["PS_FacultyLoginId"]) : PSFacultyLoginId = null;
		PSFacultyTypeId = dr["PS_FacultyTypeId"] != DBNull.Value ? Convert.ToInt64(dr["PS_FacultyTypeId"]) : PSFacultyTypeId = null;
		PSFacultyType = dr["PS_FacultyType"] != DBNull.Value ? Convert.ToString(dr["PS_FacultyType"]) : PSFacultyType = null;
		PSDisplayPhoto = dr["PS_DisplayPhoto"] != DBNull.Value ? Convert.ToString(dr["PS_DisplayPhoto"]) : PSDisplayPhoto = null;
		PSDisplayEducation = dr["PS_DisplayEducation"] != DBNull.Value ? Convert.ToString(dr["PS_DisplayEducation"]) : PSDisplayEducation = null;
		PSDisplayConatctDetails = dr["PS_DisplayConatctDetails"] != DBNull.Value ? Convert.ToString(dr["PS_DisplayConatctDetails"]) : PSDisplayConatctDetails = null;
		PSDisplayLocation = dr["PS_DisplayLocation"] != DBNull.Value ? Convert.ToString(dr["PS_DisplayLocation"]) : PSDisplayLocation = null;
		PSExtraOne = dr["PS_ExtraOne"] != DBNull.Value ? Convert.ToString(dr["PS_ExtraOne"]) : PSExtraOne = null;
		PSExtraTwo = dr["PS_ExtraTwo"] != DBNull.Value ? Convert.ToString(dr["PS_ExtraTwo"]) : PSExtraTwo = null;
		PSExtraThree = dr["PS_ExtraThree"] != DBNull.Value ? Convert.ToString(dr["PS_ExtraThree"]) : PSExtraThree = null;
		PSExtraFour = dr["PS_ExtraFour"] != DBNull.Value ? Convert.ToString(dr["PS_ExtraFour"]) : PSExtraFour = null;
		PSDate = dr["PS_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PS_Date"]) : PSDate = null;
		PSStatus = dr["PS_Status"] != DBNull.Value ? Convert.ToInt32(dr["PS_Status"]) : PSStatus = null;
	}
	
	public static TMSPrivacySettings[] MapFrom(DataSet ds)
	{
		List<TMSPrivacySettings> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPrivacySettings>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_PrivacySettings] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_PrivacySettings] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPrivacySettings instance = new TMSPrivacySettings();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrivacySettings Get(System.Int64 psPrivacyId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPrivacySettings instance;
		
		
		instance = new TMSPrivacySettings();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psPrivacyId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSPrivacySettings ID:" + psPrivacyId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psFacultyLoginId, psFacultyTypeId, psFacultyType, psDisplayPhoto, psDisplayEducation, psDisplayConatctDetails, psDisplayLocation, psExtraOne, psExtraTwo, psExtraThree, psExtraFour, psDate, psStatus);
		
		if (transaction == null)
		this.PSPrivacyId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PSPrivacyId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus)
	{
		Insert(psFacultyLoginId, psFacultyTypeId, psFacultyType, psDisplayPhoto, psDisplayEducation, psDisplayConatctDetails, psDisplayLocation, psExtraOne, psExtraTwo, psExtraThree, psExtraFour, psDate, psStatus, null);
	}
	/// <summary>
	/// Insert current TMSPrivacySettings to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PSFacultyLoginId, PSFacultyTypeId, PSFacultyType, PSDisplayPhoto, PSDisplayEducation, PSDisplayConatctDetails, PSDisplayLocation, PSExtraOne, PSExtraTwo, PSExtraThree, PSExtraFour, PSDate, PSStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPrivacySettings to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? psPrivacyId, System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@psPrivacyId"].Value = psPrivacyId;
		dbCommand.Parameters["@psFacultyLoginId"].Value = psFacultyLoginId;
		dbCommand.Parameters["@psFacultyTypeId"].Value = psFacultyTypeId;
		dbCommand.Parameters["@psFacultyType"].Value = psFacultyType;
		dbCommand.Parameters["@psDisplayPhoto"].Value = psDisplayPhoto;
		dbCommand.Parameters["@psDisplayEducation"].Value = psDisplayEducation;
		dbCommand.Parameters["@psDisplayConatctDetails"].Value = psDisplayConatctDetails;
		dbCommand.Parameters["@psDisplayLocation"].Value = psDisplayLocation;
		dbCommand.Parameters["@psExtraOne"].Value = psExtraOne;
		dbCommand.Parameters["@psExtraTwo"].Value = psExtraTwo;
		dbCommand.Parameters["@psExtraThree"].Value = psExtraThree;
		dbCommand.Parameters["@psExtraFour"].Value = psExtraFour;
		dbCommand.Parameters["@psDate"].Value = psDate;
		dbCommand.Parameters["@psStatus"].Value = psStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? psPrivacyId, System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus)
	{
		Update(psPrivacyId, psFacultyLoginId, psFacultyTypeId, psFacultyType, psDisplayPhoto, psDisplayEducation, psDisplayConatctDetails, psDisplayLocation, psExtraOne, psExtraTwo, psExtraThree, psExtraFour, psDate, psStatus, null);
	}
	
	public static void Update(TMSPrivacySettings tMSPrivacySettings)
	{
		tMSPrivacySettings.Update();
	}
	
	public static void Update(TMSPrivacySettings tMSPrivacySettings, DbTransaction transaction)
	{
		tMSPrivacySettings.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPrivacySettings_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@psPrivacyId"].SourceColumn = "PS_PrivacyId";
		dbCommand.Parameters["@psFacultyLoginId"].SourceColumn = "PS_FacultyLoginId";
		dbCommand.Parameters["@psFacultyTypeId"].SourceColumn = "PS_FacultyTypeId";
		dbCommand.Parameters["@psFacultyType"].SourceColumn = "PS_FacultyType";
		dbCommand.Parameters["@psDisplayPhoto"].SourceColumn = "PS_DisplayPhoto";
		dbCommand.Parameters["@psDisplayEducation"].SourceColumn = "PS_DisplayEducation";
		dbCommand.Parameters["@psDisplayConatctDetails"].SourceColumn = "PS_DisplayConatctDetails";
		dbCommand.Parameters["@psDisplayLocation"].SourceColumn = "PS_DisplayLocation";
		dbCommand.Parameters["@psExtraOne"].SourceColumn = "PS_ExtraOne";
		dbCommand.Parameters["@psExtraTwo"].SourceColumn = "PS_ExtraTwo";
		dbCommand.Parameters["@psExtraThree"].SourceColumn = "PS_ExtraThree";
		dbCommand.Parameters["@psExtraFour"].SourceColumn = "PS_ExtraFour";
		dbCommand.Parameters["@psDate"].SourceColumn = "PS_Date";
		dbCommand.Parameters["@psStatus"].SourceColumn = "PS_Status";
		
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
	public static void Delete(System.Int64? psPrivacyId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psPrivacyId);
		
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
	public static void Delete(System.Int64? psPrivacyId)
	{
		Delete(
		psPrivacyId);
	}
	
	/// <summary>
	/// Delete current TMSPrivacySettings from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PSPrivacyId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PSPrivacyId = null;
	}
	
	/// <summary>
	/// Delete current TMSPrivacySettings from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrivacySettings[] Search(System.Int64? psPrivacyId, System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivacySettings_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psPrivacyId, psFacultyLoginId, psFacultyTypeId, psFacultyType, psDisplayPhoto, psDisplayEducation, psDisplayConatctDetails, psDisplayLocation, psExtraOne, psExtraTwo, psExtraThree, psExtraFour, psDate, psStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPrivacySettings.MapFrom(ds);
	}
	
	
	public static TMSPrivacySettings[] Search(TMSPrivacySettings searchObject)
	{
		return Search ( searchObject.PSPrivacyId, searchObject.PSFacultyLoginId, searchObject.PSFacultyTypeId, searchObject.PSFacultyType, searchObject.PSDisplayPhoto, searchObject.PSDisplayEducation, searchObject.PSDisplayConatctDetails, searchObject.PSDisplayLocation, searchObject.PSExtraOne, searchObject.PSExtraTwo, searchObject.PSExtraThree, searchObject.PSExtraFour, searchObject.PSDate, searchObject.PSStatus);
	}
	
	/// <summary>
	/// Returns all TMSPrivacySettings objects.
	/// </summary>
	/// <returns>List of all TMSPrivacySettings objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPrivacySettings[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

