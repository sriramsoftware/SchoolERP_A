/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/10/2012 10:31:00 AM                                    */
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
public partial class TMSFeatures
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Features]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _feFeatureID;
	private System.String _feTitle;
	private System.String _feSubTitle;
	private System.String _feDescription;
	private System.String _feImage;
	private System.String _efType;
	private System.String _feImageLogo;
	private System.DateTime? _feDate;
	private System.Int32? _feStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FEFeatureID
	{
		get
		{
			return _feFeatureID;
		}
		set
		{
			_feFeatureID = value;
		}
	}
	
	public System.String FETitle
	{
		get
		{
			return _feTitle;
		}
		set
		{
			_feTitle = value;
		}
	}
	
	public System.String FESubTitle
	{
		get
		{
			return _feSubTitle;
		}
		set
		{
			_feSubTitle = value;
		}
	}
	
	public System.String FEDescription
	{
		get
		{
			return _feDescription;
		}
		set
		{
			_feDescription = value;
		}
	}
	
	public System.String FEImage
	{
		get
		{
			return _feImage;
		}
		set
		{
			_feImage = value;
		}
	}
	
	public System.String EFType
	{
		get
		{
			return _efType;
		}
		set
		{
			_efType = value;
		}
	}
	
	public System.String FEImageLogo
	{
		get
		{
			return _feImageLogo;
		}
		set
		{
			_feImageLogo = value;
		}
	}
	
	public System.DateTime? FEDate
	{
		get
		{
			return _feDate;
		}
		set
		{
			_feDate = value;
		}
	}
	
	public System.Int32? FEStatus
	{
		get
		{
			return _feStatus;
		}
		set
		{
			_feStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FE_FeatureID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_SubTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EF_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_ImageLogo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FE_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FEFeatureID == null)
		dr["FE_FeatureID"] = DBNull.Value;
		else
		dr["FE_FeatureID"] = FEFeatureID;
		
		if (FETitle == null)
		dr["FE_Title"] = DBNull.Value;
		else
		dr["FE_Title"] = FETitle;
		
		if (FESubTitle == null)
		dr["FE_SubTitle"] = DBNull.Value;
		else
		dr["FE_SubTitle"] = FESubTitle;
		
		if (FEDescription == null)
		dr["FE_Description"] = DBNull.Value;
		else
		dr["FE_Description"] = FEDescription;
		
		if (FEImage == null)
		dr["FE_Image"] = DBNull.Value;
		else
		dr["FE_Image"] = FEImage;
		
		if (EFType == null)
		dr["EF_Type"] = DBNull.Value;
		else
		dr["EF_Type"] = EFType;
		
		if (FEImageLogo == null)
		dr["FE_ImageLogo"] = DBNull.Value;
		else
		dr["FE_ImageLogo"] = FEImageLogo;
		
		if (FEDate == null)
		dr["FE_Date"] = DBNull.Value;
		else
		dr["FE_Date"] = FEDate;
		
		if (FEStatus == null)
		dr["FE_Status"] = DBNull.Value;
		else
		dr["FE_Status"] = FEStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FEFeatureID = dr["FE_FeatureID"] != DBNull.Value ? Convert.ToInt64(dr["FE_FeatureID"]) : FEFeatureID = null;
		FETitle = dr["FE_Title"] != DBNull.Value ? Convert.ToString(dr["FE_Title"]) : FETitle = null;
		FESubTitle = dr["FE_SubTitle"] != DBNull.Value ? Convert.ToString(dr["FE_SubTitle"]) : FESubTitle = null;
		FEDescription = dr["FE_Description"] != DBNull.Value ? Convert.ToString(dr["FE_Description"]) : FEDescription = null;
		FEImage = dr["FE_Image"] != DBNull.Value ? Convert.ToString(dr["FE_Image"]) : FEImage = null;
		EFType = dr["EF_Type"] != DBNull.Value ? Convert.ToString(dr["EF_Type"]) : EFType = null;
		FEImageLogo = dr["FE_ImageLogo"] != DBNull.Value ? Convert.ToString(dr["FE_ImageLogo"]) : FEImageLogo = null;
		FEDate = dr["FE_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FE_Date"]) : FEDate = null;
		FEStatus = dr["FE_Status"] != DBNull.Value ? Convert.ToInt32(dr["FE_Status"]) : FEStatus = null;
	}
	
	public static TMSFeatures[] MapFrom(DataSet ds)
	{
		List<TMSFeatures> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeatures>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Features] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Features] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeatures instance = new TMSFeatures();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeatures Get(System.Int64 feFeatureID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeatures instance;
		
		
		instance = new TMSFeatures();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeatures ID:" + feFeatureID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feTitle, feSubTitle, feDescription, feImage, efType, feImageLogo, feDate, feStatus);
		
		if (transaction == null)
		this.FEFeatureID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FEFeatureID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus)
	{
		Insert(feTitle, feSubTitle, feDescription, feImage, efType, feImageLogo, feDate, feStatus, null);
	}
	/// <summary>
	/// Insert current TMSFeatures to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FETitle, FESubTitle, FEDescription, FEImage, EFType, FEImageLogo, FEDate, FEStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeatures to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? feFeatureID, System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feFeatureID"].Value = feFeatureID;
		dbCommand.Parameters["@feTitle"].Value = feTitle;
		dbCommand.Parameters["@feSubTitle"].Value = feSubTitle;
		dbCommand.Parameters["@feDescription"].Value = feDescription;
		dbCommand.Parameters["@feImage"].Value = feImage;
		dbCommand.Parameters["@efType"].Value = efType;
		dbCommand.Parameters["@feImageLogo"].Value = feImageLogo;
		dbCommand.Parameters["@feDate"].Value = feDate;
		dbCommand.Parameters["@feStatus"].Value = feStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? feFeatureID, System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus)
	{
		Update(feFeatureID, feTitle, feSubTitle, feDescription, feImage, efType, feImageLogo, feDate, feStatus, null);
	}
	
	public static void Update(TMSFeatures tMSFeatures)
	{
		tMSFeatures.Update();
	}
	
	public static void Update(TMSFeatures tMSFeatures, DbTransaction transaction)
	{
		tMSFeatures.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeatures_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feFeatureID"].SourceColumn = "FE_FeatureID";
		dbCommand.Parameters["@feTitle"].SourceColumn = "FE_Title";
		dbCommand.Parameters["@feSubTitle"].SourceColumn = "FE_SubTitle";
		dbCommand.Parameters["@feDescription"].SourceColumn = "FE_Description";
		dbCommand.Parameters["@feImage"].SourceColumn = "FE_Image";
		dbCommand.Parameters["@efType"].SourceColumn = "EF_Type";
		dbCommand.Parameters["@feImageLogo"].SourceColumn = "FE_ImageLogo";
		dbCommand.Parameters["@feDate"].SourceColumn = "FE_Date";
		dbCommand.Parameters["@feStatus"].SourceColumn = "FE_Status";
		
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
	public static void Delete(System.Int64? feFeatureID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID);
		
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
	public static void Delete(System.Int64? feFeatureID)
	{
		Delete(
		feFeatureID);
	}
	
	/// <summary>
	/// Delete current TMSFeatures from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FEFeatureID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FEFeatureID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeatures from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeatures[] Search(System.Int64? feFeatureID, System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeatures_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID, feTitle, feSubTitle, feDescription, feImage, efType, feImageLogo, feDate, feStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeatures.MapFrom(ds);
	}
	
	
	public static TMSFeatures[] Search(TMSFeatures searchObject)
	{
		return Search ( searchObject.FEFeatureID, searchObject.FETitle, searchObject.FESubTitle, searchObject.FEDescription, searchObject.FEImage, searchObject.EFType, searchObject.FEImageLogo, searchObject.FEDate, searchObject.FEStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeatures objects.
	/// </summary>
	/// <returns>List of all TMSFeatures objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeatures[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

