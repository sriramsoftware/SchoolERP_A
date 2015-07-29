/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/25/2012 6:08:12 PM                                    */
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
public partial class TMSUploadFunstuff
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_UploadFunstuff]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ufFunStuffID;
	private System.Int64? _ufSchoolID;
	private System.Int64? _ufSchoolSubcategoryID;
	private System.Int64? _ufFacultyID;
	private System.String _ufFunType;
	private System.String _ufTitle;
	private System.String _ufDescription1;
	private System.String _ufDescription2;
	private System.String _ufCoverImage;
	private System.String _ufGameLink;
	private System.String _ufAddedby;
	private System.String _ufExtra2;
	private System.DateTime? _ufDate;
	private System.Int32? _ufStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? UFFunStuffID
	{
		get
		{
			return _ufFunStuffID;
		}
		set
		{
			_ufFunStuffID = value;
		}
	}
	
	public System.Int64? UFSchoolID
	{
		get
		{
			return _ufSchoolID;
		}
		set
		{
			_ufSchoolID = value;
		}
	}
	
	public System.Int64? UFSchoolSubcategoryID
	{
		get
		{
			return _ufSchoolSubcategoryID;
		}
		set
		{
			_ufSchoolSubcategoryID = value;
		}
	}
	
	public System.Int64? UFFacultyID
	{
		get
		{
			return _ufFacultyID;
		}
		set
		{
			_ufFacultyID = value;
		}
	}
	
	public System.String UFFunType
	{
		get
		{
			return _ufFunType;
		}
		set
		{
			_ufFunType = value;
		}
	}
	
	public System.String UFTitle
	{
		get
		{
			return _ufTitle;
		}
		set
		{
			_ufTitle = value;
		}
	}
	
	public System.String UFDescription1
	{
		get
		{
			return _ufDescription1;
		}
		set
		{
			_ufDescription1 = value;
		}
	}
	
	public System.String UFDescription2
	{
		get
		{
			return _ufDescription2;
		}
		set
		{
			_ufDescription2 = value;
		}
	}
	
	public System.String UFCoverImage
	{
		get
		{
			return _ufCoverImage;
		}
		set
		{
			_ufCoverImage = value;
		}
	}
	
	public System.String UFGameLink
	{
		get
		{
			return _ufGameLink;
		}
		set
		{
			_ufGameLink = value;
		}
	}
	
	public System.String UFAddedby
	{
		get
		{
			return _ufAddedby;
		}
		set
		{
			_ufAddedby = value;
		}
	}
	
	public System.String UFExtra2
	{
		get
		{
			return _ufExtra2;
		}
		set
		{
			_ufExtra2 = value;
		}
	}
	
	public System.DateTime? UFDate
	{
		get
		{
			return _ufDate;
		}
		set
		{
			_ufDate = value;
		}
	}
	
	public System.Int32? UFStatus
	{
		get
		{
			return _ufStatus;
		}
		set
		{
			_ufStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("UF_FunStuffID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_SchoolID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_SchoolSubcategoryID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_FacultyID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_FunType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Description2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_CoverImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_GameLink", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Addedby", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UF_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (UFFunStuffID == null)
		dr["UF_FunStuffID"] = DBNull.Value;
		else
		dr["UF_FunStuffID"] = UFFunStuffID;
		
		if (UFSchoolID == null)
		dr["UF_SchoolID"] = DBNull.Value;
		else
		dr["UF_SchoolID"] = UFSchoolID;
		
		if (UFSchoolSubcategoryID == null)
		dr["UF_SchoolSubcategoryID"] = DBNull.Value;
		else
		dr["UF_SchoolSubcategoryID"] = UFSchoolSubcategoryID;
		
		if (UFFacultyID == null)
		dr["UF_FacultyID"] = DBNull.Value;
		else
		dr["UF_FacultyID"] = UFFacultyID;
		
		if (UFFunType == null)
		dr["UF_FunType"] = DBNull.Value;
		else
		dr["UF_FunType"] = UFFunType;
		
		if (UFTitle == null)
		dr["UF_Title"] = DBNull.Value;
		else
		dr["UF_Title"] = UFTitle;
		
		if (UFDescription1 == null)
		dr["UF_Description1"] = DBNull.Value;
		else
		dr["UF_Description1"] = UFDescription1;
		
		if (UFDescription2 == null)
		dr["UF_Description2"] = DBNull.Value;
		else
		dr["UF_Description2"] = UFDescription2;
		
		if (UFCoverImage == null)
		dr["UF_CoverImage"] = DBNull.Value;
		else
		dr["UF_CoverImage"] = UFCoverImage;
		
		if (UFGameLink == null)
		dr["UF_GameLink"] = DBNull.Value;
		else
		dr["UF_GameLink"] = UFGameLink;
		
		if (UFAddedby == null)
		dr["UF_Addedby"] = DBNull.Value;
		else
		dr["UF_Addedby"] = UFAddedby;
		
		if (UFExtra2 == null)
		dr["UF_Extra2"] = DBNull.Value;
		else
		dr["UF_Extra2"] = UFExtra2;
		
		if (UFDate == null)
		dr["UF_Date"] = DBNull.Value;
		else
		dr["UF_Date"] = UFDate;
		
		if (UFStatus == null)
		dr["UF_Status"] = DBNull.Value;
		else
		dr["UF_Status"] = UFStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		UFFunStuffID = dr["UF_FunStuffID"] != DBNull.Value ? Convert.ToInt64(dr["UF_FunStuffID"]) : UFFunStuffID = null;
		UFSchoolID = dr["UF_SchoolID"] != DBNull.Value ? Convert.ToInt64(dr["UF_SchoolID"]) : UFSchoolID = null;
		UFSchoolSubcategoryID = dr["UF_SchoolSubcategoryID"] != DBNull.Value ? Convert.ToInt64(dr["UF_SchoolSubcategoryID"]) : UFSchoolSubcategoryID = null;
		UFFacultyID = dr["UF_FacultyID"] != DBNull.Value ? Convert.ToInt64(dr["UF_FacultyID"]) : UFFacultyID = null;
		UFFunType = dr["UF_FunType"] != DBNull.Value ? Convert.ToString(dr["UF_FunType"]) : UFFunType = null;
		UFTitle = dr["UF_Title"] != DBNull.Value ? Convert.ToString(dr["UF_Title"]) : UFTitle = null;
		UFDescription1 = dr["UF_Description1"] != DBNull.Value ? Convert.ToString(dr["UF_Description1"]) : UFDescription1 = null;
		UFDescription2 = dr["UF_Description2"] != DBNull.Value ? Convert.ToString(dr["UF_Description2"]) : UFDescription2 = null;
		UFCoverImage = dr["UF_CoverImage"] != DBNull.Value ? Convert.ToString(dr["UF_CoverImage"]) : UFCoverImage = null;
		UFGameLink = dr["UF_GameLink"] != DBNull.Value ? Convert.ToString(dr["UF_GameLink"]) : UFGameLink = null;
		UFAddedby = dr["UF_Addedby"] != DBNull.Value ? Convert.ToString(dr["UF_Addedby"]) : UFAddedby = null;
		UFExtra2 = dr["UF_Extra2"] != DBNull.Value ? Convert.ToString(dr["UF_Extra2"]) : UFExtra2 = null;
		UFDate = dr["UF_Date"] != DBNull.Value ? Convert.ToDateTime(dr["UF_Date"]) : UFDate = null;
		UFStatus = dr["UF_Status"] != DBNull.Value ? Convert.ToInt32(dr["UF_Status"]) : UFStatus = null;
	}
	
	public static TMSUploadFunstuff[] MapFrom(DataSet ds)
	{
		List<TMSUploadFunstuff> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSUploadFunstuff>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_UploadFunstuff] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_UploadFunstuff] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSUploadFunstuff instance = new TMSUploadFunstuff();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUploadFunstuff Get(System.Int64 ufFunStuffID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSUploadFunstuff instance;
		
		
		instance = new TMSUploadFunstuff();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ufFunStuffID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSUploadFunstuff ID:" + ufFunStuffID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ufSchoolID, ufSchoolSubcategoryID, ufFacultyID, ufFunType, ufTitle, ufDescription1, ufDescription2, ufCoverImage, ufGameLink, ufAddedby, ufExtra2, ufDate, ufStatus);
		
		if (transaction == null)
		this.UFFunStuffID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.UFFunStuffID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus)
	{
		Insert(ufSchoolID, ufSchoolSubcategoryID, ufFacultyID, ufFunType, ufTitle, ufDescription1, ufDescription2, ufCoverImage, ufGameLink, ufAddedby, ufExtra2, ufDate, ufStatus, null);
	}
	/// <summary>
	/// Insert current TMSUploadFunstuff to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(UFSchoolID, UFSchoolSubcategoryID, UFFacultyID, UFFunType, UFTitle, UFDescription1, UFDescription2, UFCoverImage, UFGameLink, UFAddedby, UFExtra2, UFDate, UFStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSUploadFunstuff to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ufFunStuffID, System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ufFunStuffID"].Value = ufFunStuffID;
		dbCommand.Parameters["@ufSchoolID"].Value = ufSchoolID;
		dbCommand.Parameters["@ufSchoolSubcategoryID"].Value = ufSchoolSubcategoryID;
		dbCommand.Parameters["@ufFacultyID"].Value = ufFacultyID;
		dbCommand.Parameters["@ufFunType"].Value = ufFunType;
		dbCommand.Parameters["@ufTitle"].Value = ufTitle;
		dbCommand.Parameters["@ufDescription1"].Value = ufDescription1;
		dbCommand.Parameters["@ufDescription2"].Value = ufDescription2;
		dbCommand.Parameters["@ufCoverImage"].Value = ufCoverImage;
		dbCommand.Parameters["@ufGameLink"].Value = ufGameLink;
		dbCommand.Parameters["@ufAddedby"].Value = ufAddedby;
		dbCommand.Parameters["@ufExtra2"].Value = ufExtra2;
		dbCommand.Parameters["@ufDate"].Value = ufDate;
		dbCommand.Parameters["@ufStatus"].Value = ufStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ufFunStuffID, System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus)
	{
		Update(ufFunStuffID, ufSchoolID, ufSchoolSubcategoryID, ufFacultyID, ufFunType, ufTitle, ufDescription1, ufDescription2, ufCoverImage, ufGameLink, ufAddedby, ufExtra2, ufDate, ufStatus, null);
	}
	
	public static void Update(TMSUploadFunstuff tMSUploadFunstuff)
	{
		tMSUploadFunstuff.Update();
	}
	
	public static void Update(TMSUploadFunstuff tMSUploadFunstuff, DbTransaction transaction)
	{
		tMSUploadFunstuff.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSUploadFunstuff_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ufFunStuffID"].SourceColumn = "UF_FunStuffID";
		dbCommand.Parameters["@ufSchoolID"].SourceColumn = "UF_SchoolID";
		dbCommand.Parameters["@ufSchoolSubcategoryID"].SourceColumn = "UF_SchoolSubcategoryID";
		dbCommand.Parameters["@ufFacultyID"].SourceColumn = "UF_FacultyID";
		dbCommand.Parameters["@ufFunType"].SourceColumn = "UF_FunType";
		dbCommand.Parameters["@ufTitle"].SourceColumn = "UF_Title";
		dbCommand.Parameters["@ufDescription1"].SourceColumn = "UF_Description1";
		dbCommand.Parameters["@ufDescription2"].SourceColumn = "UF_Description2";
		dbCommand.Parameters["@ufCoverImage"].SourceColumn = "UF_CoverImage";
		dbCommand.Parameters["@ufGameLink"].SourceColumn = "UF_GameLink";
		dbCommand.Parameters["@ufAddedby"].SourceColumn = "UF_Addedby";
		dbCommand.Parameters["@ufExtra2"].SourceColumn = "UF_Extra2";
		dbCommand.Parameters["@ufDate"].SourceColumn = "UF_Date";
		dbCommand.Parameters["@ufStatus"].SourceColumn = "UF_Status";
		
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
	public static void Delete(System.Int64? ufFunStuffID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ufFunStuffID);
		
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
	public static void Delete(System.Int64? ufFunStuffID)
	{
		Delete(
		ufFunStuffID);
	}
	
	/// <summary>
	/// Delete current TMSUploadFunstuff from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, UFFunStuffID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.UFFunStuffID = null;
	}
	
	/// <summary>
	/// Delete current TMSUploadFunstuff from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUploadFunstuff[] Search(System.Int64? ufFunStuffID, System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadFunstuff_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ufFunStuffID, ufSchoolID, ufSchoolSubcategoryID, ufFacultyID, ufFunType, ufTitle, ufDescription1, ufDescription2, ufCoverImage, ufGameLink, ufAddedby, ufExtra2, ufDate, ufStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSUploadFunstuff.MapFrom(ds);
	}
	
	
	public static TMSUploadFunstuff[] Search(TMSUploadFunstuff searchObject)
	{
		return Search ( searchObject.UFFunStuffID, searchObject.UFSchoolID, searchObject.UFSchoolSubcategoryID, searchObject.UFFacultyID, searchObject.UFFunType, searchObject.UFTitle, searchObject.UFDescription1, searchObject.UFDescription2, searchObject.UFCoverImage, searchObject.UFGameLink, searchObject.UFAddedby, searchObject.UFExtra2, searchObject.UFDate, searchObject.UFStatus);
	}
	
	/// <summary>
	/// Returns all TMSUploadFunstuff objects.
	/// </summary>
	/// <returns>List of all TMSUploadFunstuff objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSUploadFunstuff[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

