/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/3/2012 5:01:04 PM                                    */
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
public partial class TMSOtherExpensesDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_OtherExpensesDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _spoeDetailsId;
	private System.String _spoeTitle;
	private System.String _spoeItemName;
	private System.String _spoeType;
	private System.String _spoeQuantity;
	private System.String _spoeDescription;
	private System.Double? _spoeTotalAmount;
	private System.String _spoeMonth;
	private System.String _spoeYear;
	private System.DateTime? _spoeTransactionDate;
	private System.Int64? _spoeAddedById;
	private System.String _spoeAddedByRemark;
	private System.String _spoeExtraOne;
	private System.String _spoeExtraTwo;
	private System.DateTime? _spoeDate;
	private System.Int32? _spoeStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SPOEDetailsId
	{
		get
		{
			return _spoeDetailsId;
		}
		set
		{
			_spoeDetailsId = value;
		}
	}
	
	public System.String SPOETitle
	{
		get
		{
			return _spoeTitle;
		}
		set
		{
			_spoeTitle = value;
		}
	}
	
	public System.String SPOEItemName
	{
		get
		{
			return _spoeItemName;
		}
		set
		{
			_spoeItemName = value;
		}
	}
	
	public System.String SPOEType
	{
		get
		{
			return _spoeType;
		}
		set
		{
			_spoeType = value;
		}
	}
	
	public System.String SPOEQuantity
	{
		get
		{
			return _spoeQuantity;
		}
		set
		{
			_spoeQuantity = value;
		}
	}
	
	public System.String SPOEDescription
	{
		get
		{
			return _spoeDescription;
		}
		set
		{
			_spoeDescription = value;
		}
	}
	
	public System.Double? SPOETotalAmount
	{
		get
		{
			return _spoeTotalAmount;
		}
		set
		{
			_spoeTotalAmount = value;
		}
	}
	
	public System.String SPOEMonth
	{
		get
		{
			return _spoeMonth;
		}
		set
		{
			_spoeMonth = value;
		}
	}
	
	public System.String SPOEYear
	{
		get
		{
			return _spoeYear;
		}
		set
		{
			_spoeYear = value;
		}
	}
	
	public System.DateTime? SPOETransactionDate
	{
		get
		{
			return _spoeTransactionDate;
		}
		set
		{
			_spoeTransactionDate = value;
		}
	}
	
	public System.Int64? SPOEAddedById
	{
		get
		{
			return _spoeAddedById;
		}
		set
		{
			_spoeAddedById = value;
		}
	}
	
	public System.String SPOEAddedByRemark
	{
		get
		{
			return _spoeAddedByRemark;
		}
		set
		{
			_spoeAddedByRemark = value;
		}
	}
	
	public System.String SPOEExtraOne
	{
		get
		{
			return _spoeExtraOne;
		}
		set
		{
			_spoeExtraOne = value;
		}
	}
	
	public System.String SPOEExtraTwo
	{
		get
		{
			return _spoeExtraTwo;
		}
		set
		{
			_spoeExtraTwo = value;
		}
	}
	
	public System.DateTime? SPOEDate
	{
		get
		{
			return _spoeDate;
		}
		set
		{
			_spoeDate = value;
		}
	}
	
	public System.Int32? SPOEStatus
	{
		get
		{
			return _spoeStatus;
		}
		set
		{
			_spoeStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_ItemName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Quantity", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_TotalAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_TransactionDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_AddedByRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_ExtraOne", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_ExtraTwo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SPOE_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SPOEDetailsId == null)
		dr["SPOE_DetailsId"] = DBNull.Value;
		else
		dr["SPOE_DetailsId"] = SPOEDetailsId;
		
		if (SPOETitle == null)
		dr["SPOE_Title"] = DBNull.Value;
		else
		dr["SPOE_Title"] = SPOETitle;
		
		if (SPOEItemName == null)
		dr["SPOE_ItemName"] = DBNull.Value;
		else
		dr["SPOE_ItemName"] = SPOEItemName;
		
		if (SPOEType == null)
		dr["SPOE_Type"] = DBNull.Value;
		else
		dr["SPOE_Type"] = SPOEType;
		
		if (SPOEQuantity == null)
		dr["SPOE_Quantity"] = DBNull.Value;
		else
		dr["SPOE_Quantity"] = SPOEQuantity;
		
		if (SPOEDescription == null)
		dr["SPOE_Description"] = DBNull.Value;
		else
		dr["SPOE_Description"] = SPOEDescription;
		
		if (SPOETotalAmount == null)
		dr["SPOE_TotalAmount"] = DBNull.Value;
		else
		dr["SPOE_TotalAmount"] = SPOETotalAmount;
		
		if (SPOEMonth == null)
		dr["SPOE_Month"] = DBNull.Value;
		else
		dr["SPOE_Month"] = SPOEMonth;
		
		if (SPOEYear == null)
		dr["SPOE_Year"] = DBNull.Value;
		else
		dr["SPOE_Year"] = SPOEYear;
		
		if (SPOETransactionDate == null)
		dr["SPOE_TransactionDate"] = DBNull.Value;
		else
		dr["SPOE_TransactionDate"] = SPOETransactionDate;
		
		if (SPOEAddedById == null)
		dr["SPOE_AddedById"] = DBNull.Value;
		else
		dr["SPOE_AddedById"] = SPOEAddedById;
		
		if (SPOEAddedByRemark == null)
		dr["SPOE_AddedByRemark"] = DBNull.Value;
		else
		dr["SPOE_AddedByRemark"] = SPOEAddedByRemark;
		
		if (SPOEExtraOne == null)
		dr["SPOE_ExtraOne"] = DBNull.Value;
		else
		dr["SPOE_ExtraOne"] = SPOEExtraOne;
		
		if (SPOEExtraTwo == null)
		dr["SPOE_ExtraTwo"] = DBNull.Value;
		else
		dr["SPOE_ExtraTwo"] = SPOEExtraTwo;
		
		if (SPOEDate == null)
		dr["SPOE_Date"] = DBNull.Value;
		else
		dr["SPOE_Date"] = SPOEDate;
		
		if (SPOEStatus == null)
		dr["SPOE_Status"] = DBNull.Value;
		else
		dr["SPOE_Status"] = SPOEStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SPOEDetailsId = dr["SPOE_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["SPOE_DetailsId"]) : SPOEDetailsId = null;
		SPOETitle = dr["SPOE_Title"] != DBNull.Value ? Convert.ToString(dr["SPOE_Title"]) : SPOETitle = null;
		SPOEItemName = dr["SPOE_ItemName"] != DBNull.Value ? Convert.ToString(dr["SPOE_ItemName"]) : SPOEItemName = null;
		SPOEType = dr["SPOE_Type"] != DBNull.Value ? Convert.ToString(dr["SPOE_Type"]) : SPOEType = null;
		SPOEQuantity = dr["SPOE_Quantity"] != DBNull.Value ? Convert.ToString(dr["SPOE_Quantity"]) : SPOEQuantity = null;
		SPOEDescription = dr["SPOE_Description"] != DBNull.Value ? Convert.ToString(dr["SPOE_Description"]) : SPOEDescription = null;
		SPOETotalAmount = dr["SPOE_TotalAmount"] != DBNull.Value ? Convert.ToDouble(dr["SPOE_TotalAmount"]) : SPOETotalAmount = null;
		SPOEMonth = dr["SPOE_Month"] != DBNull.Value ? Convert.ToString(dr["SPOE_Month"]) : SPOEMonth = null;
		SPOEYear = dr["SPOE_Year"] != DBNull.Value ? Convert.ToString(dr["SPOE_Year"]) : SPOEYear = null;
		SPOETransactionDate = dr["SPOE_TransactionDate"] != DBNull.Value ? Convert.ToDateTime(dr["SPOE_TransactionDate"]) : SPOETransactionDate = null;
		SPOEAddedById = dr["SPOE_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["SPOE_AddedById"]) : SPOEAddedById = null;
		SPOEAddedByRemark = dr["SPOE_AddedByRemark"] != DBNull.Value ? Convert.ToString(dr["SPOE_AddedByRemark"]) : SPOEAddedByRemark = null;
		SPOEExtraOne = dr["SPOE_ExtraOne"] != DBNull.Value ? Convert.ToString(dr["SPOE_ExtraOne"]) : SPOEExtraOne = null;
		SPOEExtraTwo = dr["SPOE_ExtraTwo"] != DBNull.Value ? Convert.ToString(dr["SPOE_ExtraTwo"]) : SPOEExtraTwo = null;
		SPOEDate = dr["SPOE_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SPOE_Date"]) : SPOEDate = null;
		SPOEStatus = dr["SPOE_Status"] != DBNull.Value ? Convert.ToInt32(dr["SPOE_Status"]) : SPOEStatus = null;
	}
	
	public static TMSOtherExpensesDetails[] MapFrom(DataSet ds)
	{
		List<TMSOtherExpensesDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSOtherExpensesDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_OtherExpensesDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_OtherExpensesDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSOtherExpensesDetails instance = new TMSOtherExpensesDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOtherExpensesDetails Get(System.Int64 spoeDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSOtherExpensesDetails instance;
		
		
		instance = new TMSOtherExpensesDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, spoeDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSOtherExpensesDetails ID:" + spoeDetailsId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeDescription, spoeTotalAmount, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark, spoeExtraOne, spoeExtraTwo, spoeDate, spoeStatus);
		
		if (transaction == null)
		this.SPOEDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SPOEDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus)
	{
		Insert(spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeDescription, spoeTotalAmount, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark, spoeExtraOne, spoeExtraTwo, spoeDate, spoeStatus, null);
	}
	/// <summary>
	/// Insert current TMSOtherExpensesDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SPOETitle, SPOEItemName, SPOEType, SPOEQuantity, SPOEDescription, SPOETotalAmount, SPOEMonth, SPOEYear, SPOETransactionDate, SPOEAddedById, SPOEAddedByRemark, SPOEExtraOne, SPOEExtraTwo, SPOEDate, SPOEStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSOtherExpensesDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? spoeDetailsId, System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@spoeDetailsId"].Value = spoeDetailsId;
		dbCommand.Parameters["@spoeTitle"].Value = spoeTitle;
		dbCommand.Parameters["@spoeItemName"].Value = spoeItemName;
		dbCommand.Parameters["@spoeType"].Value = spoeType;
		dbCommand.Parameters["@spoeQuantity"].Value = spoeQuantity;
		dbCommand.Parameters["@spoeDescription"].Value = spoeDescription;
		dbCommand.Parameters["@spoeTotalAmount"].Value = spoeTotalAmount;
		dbCommand.Parameters["@spoeMonth"].Value = spoeMonth;
		dbCommand.Parameters["@spoeYear"].Value = spoeYear;
		dbCommand.Parameters["@spoeTransactionDate"].Value = spoeTransactionDate;
		dbCommand.Parameters["@spoeAddedById"].Value = spoeAddedById;
		dbCommand.Parameters["@spoeAddedByRemark"].Value = spoeAddedByRemark;
		dbCommand.Parameters["@spoeExtraOne"].Value = spoeExtraOne;
		dbCommand.Parameters["@spoeExtraTwo"].Value = spoeExtraTwo;
		dbCommand.Parameters["@spoeDate"].Value = spoeDate;
		dbCommand.Parameters["@spoeStatus"].Value = spoeStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? spoeDetailsId, System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus)
	{
		Update(spoeDetailsId, spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeDescription, spoeTotalAmount, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark, spoeExtraOne, spoeExtraTwo, spoeDate, spoeStatus, null);
	}
	
	public static void Update(TMSOtherExpensesDetails tMSOtherExpensesDetails)
	{
		tMSOtherExpensesDetails.Update();
	}
	
	public static void Update(TMSOtherExpensesDetails tMSOtherExpensesDetails, DbTransaction transaction)
	{
		tMSOtherExpensesDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@spoeDetailsId"].SourceColumn = "SPOE_DetailsId";
		dbCommand.Parameters["@spoeTitle"].SourceColumn = "SPOE_Title";
		dbCommand.Parameters["@spoeItemName"].SourceColumn = "SPOE_ItemName";
		dbCommand.Parameters["@spoeType"].SourceColumn = "SPOE_Type";
		dbCommand.Parameters["@spoeQuantity"].SourceColumn = "SPOE_Quantity";
		dbCommand.Parameters["@spoeDescription"].SourceColumn = "SPOE_Description";
		dbCommand.Parameters["@spoeTotalAmount"].SourceColumn = "SPOE_TotalAmount";
		dbCommand.Parameters["@spoeMonth"].SourceColumn = "SPOE_Month";
		dbCommand.Parameters["@spoeYear"].SourceColumn = "SPOE_Year";
		dbCommand.Parameters["@spoeTransactionDate"].SourceColumn = "SPOE_TransactionDate";
		dbCommand.Parameters["@spoeAddedById"].SourceColumn = "SPOE_AddedById";
		dbCommand.Parameters["@spoeAddedByRemark"].SourceColumn = "SPOE_AddedByRemark";
		dbCommand.Parameters["@spoeExtraOne"].SourceColumn = "SPOE_ExtraOne";
		dbCommand.Parameters["@spoeExtraTwo"].SourceColumn = "SPOE_ExtraTwo";
		dbCommand.Parameters["@spoeDate"].SourceColumn = "SPOE_Date";
		dbCommand.Parameters["@spoeStatus"].SourceColumn = "SPOE_Status";
		
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
	public static void Delete(System.Int64? spoeDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, spoeDetailsId);
		
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
	public static void Delete(System.Int64? spoeDetailsId)
	{
		Delete(
		spoeDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSOtherExpensesDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SPOEDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SPOEDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSOtherExpensesDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOtherExpensesDetails[] Search(System.Int64? spoeDetailsId, System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherExpensesDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, spoeDetailsId, spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeDescription, spoeTotalAmount, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark, spoeExtraOne, spoeExtraTwo, spoeDate, spoeStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSOtherExpensesDetails.MapFrom(ds);
	}
	
	
	public static TMSOtherExpensesDetails[] Search(TMSOtherExpensesDetails searchObject)
	{
		return Search ( searchObject.SPOEDetailsId, searchObject.SPOETitle, searchObject.SPOEItemName, searchObject.SPOEType, searchObject.SPOEQuantity, searchObject.SPOEDescription, searchObject.SPOETotalAmount, searchObject.SPOEMonth, searchObject.SPOEYear, searchObject.SPOETransactionDate, searchObject.SPOEAddedById, searchObject.SPOEAddedByRemark, searchObject.SPOEExtraOne, searchObject.SPOEExtraTwo, searchObject.SPOEDate, searchObject.SPOEStatus);
	}
	
	/// <summary>
	/// Returns all TMSOtherExpensesDetails objects.
	/// </summary>
	/// <returns>List of all TMSOtherExpensesDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSOtherExpensesDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

