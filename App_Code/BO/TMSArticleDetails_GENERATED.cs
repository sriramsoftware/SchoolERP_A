/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/25/2012 2:30:41 PM                                    */
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
public partial class TMSArticleDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ArticleDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adDetailId;
	private System.Int64? _adLoginId;
	private System.String _adLoginType;
	private System.String _adTitle;
	private System.String _adSubTitle;
	private System.String _adImage;
	private System.String _adDescription;
	private System.Int64? _adAddedById;
	private System.String _adAddedByType;
	private System.DateTime? _adDate;
	private System.Int32? _adStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADDetailId
	{
		get
		{
			return _adDetailId;
		}
		set
		{
			_adDetailId = value;
		}
	}
	
	public System.Int64? ADLoginId
	{
		get
		{
			return _adLoginId;
		}
		set
		{
			_adLoginId = value;
		}
	}
	
	public System.String ADLoginType
	{
		get
		{
			return _adLoginType;
		}
		set
		{
			_adLoginType = value;
		}
	}
	
	public System.String ADTitle
	{
		get
		{
			return _adTitle;
		}
		set
		{
			_adTitle = value;
		}
	}
	
	public System.String ADSubTitle
	{
		get
		{
			return _adSubTitle;
		}
		set
		{
			_adSubTitle = value;
		}
	}
	
	public System.String ADImage
	{
		get
		{
			return _adImage;
		}
		set
		{
			_adImage = value;
		}
	}
	
	public System.String ADDescription
	{
		get
		{
			return _adDescription;
		}
		set
		{
			_adDescription = value;
		}
	}
	
	public System.Int64? ADAddedById
	{
		get
		{
			return _adAddedById;
		}
		set
		{
			_adAddedById = value;
		}
	}
	
	public System.String ADAddedByType
	{
		get
		{
			return _adAddedByType;
		}
		set
		{
			_adAddedByType = value;
		}
	}
	
	public System.DateTime? ADDate
	{
		get
		{
			return _adDate;
		}
		set
		{
			_adDate = value;
		}
	}
	
	public System.Int32? ADStatus
	{
		get
		{
			return _adStatus;
		}
		set
		{
			_adStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_DetailId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_LoginType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SubTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADDetailId == null)
		dr["AD_DetailId"] = DBNull.Value;
		else
		dr["AD_DetailId"] = ADDetailId;
		
		if (ADLoginId == null)
		dr["AD_LoginId"] = DBNull.Value;
		else
		dr["AD_LoginId"] = ADLoginId;
		
		if (ADLoginType == null)
		dr["AD_LoginType"] = DBNull.Value;
		else
		dr["AD_LoginType"] = ADLoginType;
		
		if (ADTitle == null)
		dr["AD_Title"] = DBNull.Value;
		else
		dr["AD_Title"] = ADTitle;
		
		if (ADSubTitle == null)
		dr["AD_SubTitle"] = DBNull.Value;
		else
		dr["AD_SubTitle"] = ADSubTitle;
		
		if (ADImage == null)
		dr["AD_Image"] = DBNull.Value;
		else
		dr["AD_Image"] = ADImage;
		
		if (ADDescription == null)
		dr["AD_Description"] = DBNull.Value;
		else
		dr["AD_Description"] = ADDescription;
		
		if (ADAddedById == null)
		dr["AD_AddedById"] = DBNull.Value;
		else
		dr["AD_AddedById"] = ADAddedById;
		
		if (ADAddedByType == null)
		dr["AD_AddedByType"] = DBNull.Value;
		else
		dr["AD_AddedByType"] = ADAddedByType;
		
		if (ADDate == null)
		dr["AD_Date"] = DBNull.Value;
		else
		dr["AD_Date"] = ADDate;
		
		if (ADStatus == null)
		dr["AD_Status"] = DBNull.Value;
		else
		dr["AD_Status"] = ADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADDetailId = dr["AD_DetailId"] != DBNull.Value ? Convert.ToInt64(dr["AD_DetailId"]) : ADDetailId = null;
		ADLoginId = dr["AD_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["AD_LoginId"]) : ADLoginId = null;
		ADLoginType = dr["AD_LoginType"] != DBNull.Value ? Convert.ToString(dr["AD_LoginType"]) : ADLoginType = null;
		ADTitle = dr["AD_Title"] != DBNull.Value ? Convert.ToString(dr["AD_Title"]) : ADTitle = null;
		ADSubTitle = dr["AD_SubTitle"] != DBNull.Value ? Convert.ToString(dr["AD_SubTitle"]) : ADSubTitle = null;
		ADImage = dr["AD_Image"] != DBNull.Value ? Convert.ToString(dr["AD_Image"]) : ADImage = null;
		ADDescription = dr["AD_Description"] != DBNull.Value ? Convert.ToString(dr["AD_Description"]) : ADDescription = null;
		ADAddedById = dr["AD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["AD_AddedById"]) : ADAddedById = null;
		ADAddedByType = dr["AD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["AD_AddedByType"]) : ADAddedByType = null;
		ADDate = dr["AD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AD_Date"]) : ADDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
	}
	
	public static TMSArticleDetails[] MapFrom(DataSet ds)
	{
		List<TMSArticleDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSArticleDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ArticleDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ArticleDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSArticleDetails instance = new TMSArticleDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSArticleDetails Get(System.Int64 adDetailId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSArticleDetails instance;
		
		
		instance = new TMSArticleDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adDetailId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSArticleDetails ID:" + adDetailId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adLoginId, adLoginType, adTitle, adSubTitle, adImage, adDescription, adAddedById, adAddedByType, adDate, adStatus);
		
		if (transaction == null)
		this.ADDetailId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADDetailId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus)
	{
		Insert(adLoginId, adLoginType, adTitle, adSubTitle, adImage, adDescription, adAddedById, adAddedByType, adDate, adStatus, null);
	}
	/// <summary>
	/// Insert current TMSArticleDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADLoginId, ADLoginType, ADTitle, ADSubTitle, ADImage, ADDescription, ADAddedById, ADAddedByType, ADDate, ADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSArticleDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adDetailId, System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adDetailId"].Value = adDetailId;
		dbCommand.Parameters["@adLoginId"].Value = adLoginId;
		dbCommand.Parameters["@adLoginType"].Value = adLoginType;
		dbCommand.Parameters["@adTitle"].Value = adTitle;
		dbCommand.Parameters["@adSubTitle"].Value = adSubTitle;
		dbCommand.Parameters["@adImage"].Value = adImage;
		dbCommand.Parameters["@adDescription"].Value = adDescription;
		dbCommand.Parameters["@adAddedById"].Value = adAddedById;
		dbCommand.Parameters["@adAddedByType"].Value = adAddedByType;
		dbCommand.Parameters["@adDate"].Value = adDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adDetailId, System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus)
	{
		Update(adDetailId, adLoginId, adLoginType, adTitle, adSubTitle, adImage, adDescription, adAddedById, adAddedByType, adDate, adStatus, null);
	}
	
	public static void Update(TMSArticleDetails tMSArticleDetails)
	{
		tMSArticleDetails.Update();
	}
	
	public static void Update(TMSArticleDetails tMSArticleDetails, DbTransaction transaction)
	{
		tMSArticleDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSArticleDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adDetailId"].SourceColumn = "AD_DetailId";
		dbCommand.Parameters["@adLoginId"].SourceColumn = "AD_LoginId";
		dbCommand.Parameters["@adLoginType"].SourceColumn = "AD_LoginType";
		dbCommand.Parameters["@adTitle"].SourceColumn = "AD_Title";
		dbCommand.Parameters["@adSubTitle"].SourceColumn = "AD_SubTitle";
		dbCommand.Parameters["@adImage"].SourceColumn = "AD_Image";
		dbCommand.Parameters["@adDescription"].SourceColumn = "AD_Description";
		dbCommand.Parameters["@adAddedById"].SourceColumn = "AD_AddedById";
		dbCommand.Parameters["@adAddedByType"].SourceColumn = "AD_AddedByType";
		dbCommand.Parameters["@adDate"].SourceColumn = "AD_Date";
		dbCommand.Parameters["@adStatus"].SourceColumn = "AD_Status";
		
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
	public static void Delete(System.Int64? adDetailId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adDetailId);
		
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
	public static void Delete(System.Int64? adDetailId)
	{
		Delete(
		adDetailId);
	}
	
	/// <summary>
	/// Delete current TMSArticleDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADDetailId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADDetailId = null;
	}
	
	/// <summary>
	/// Delete current TMSArticleDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSArticleDetails[] Search(System.Int64? adDetailId, System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adDetailId, adLoginId, adLoginType, adTitle, adSubTitle, adImage, adDescription, adAddedById, adAddedByType, adDate, adStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSArticleDetails.MapFrom(ds);
	}
	
	
	public static TMSArticleDetails[] Search(TMSArticleDetails searchObject)
	{
		return Search ( searchObject.ADDetailId, searchObject.ADLoginId, searchObject.ADLoginType, searchObject.ADTitle, searchObject.ADSubTitle, searchObject.ADImage, searchObject.ADDescription, searchObject.ADAddedById, searchObject.ADAddedByType, searchObject.ADDate, searchObject.ADStatus);
	}
	
	/// <summary>
	/// Returns all TMSArticleDetails objects.
	/// </summary>
	/// <returns>List of all TMSArticleDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSArticleDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

