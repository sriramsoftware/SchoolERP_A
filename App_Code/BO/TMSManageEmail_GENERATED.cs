/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/28/2012 10:22:28 AM                                    */
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
public partial class TMSManageEmail
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ManageEmail]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _emailId;
	private System.Int32? _emailTemplateId;
	private System.String _emailType;
	private System.String _emailSubject;
	private System.String _emailContent;
	private System.Int32? _emailUserType;
	
	#endregion
	
	
	#region Properties
	public System.Int32? EmailId
	{
		get
		{
			return _emailId;
		}
		set
		{
			_emailId = value;
		}
	}
	
	public System.Int32? EmailTemplateId
	{
		get
		{
			return _emailTemplateId;
		}
		set
		{
			_emailTemplateId = value;
		}
	}
	
	public System.String EmailType
	{
		get
		{
			return _emailType;
		}
		set
		{
			_emailType = value;
		}
	}
	
	public System.String EmailSubject
	{
		get
		{
			return _emailSubject;
		}
		set
		{
			_emailSubject = value;
		}
	}
	
	public System.String EmailContent
	{
		get
		{
			return _emailContent;
		}
		set
		{
			_emailContent = value;
		}
	}
	
	public System.Int32? EmailUserType
	{
		get
		{
			return _emailUserType;
		}
		set
		{
			_emailUserType = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Email_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Email_TemplateId", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Email_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Email_Subject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Email_Content", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Email_UserType", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EmailId == null)
		dr["Email_Id"] = DBNull.Value;
		else
		dr["Email_Id"] = EmailId;
		
		if (EmailTemplateId == null)
		dr["Email_TemplateId"] = DBNull.Value;
		else
		dr["Email_TemplateId"] = EmailTemplateId;
		
		if (EmailType == null)
		dr["Email_Type"] = DBNull.Value;
		else
		dr["Email_Type"] = EmailType;
		
		if (EmailSubject == null)
		dr["Email_Subject"] = DBNull.Value;
		else
		dr["Email_Subject"] = EmailSubject;
		
		if (EmailContent == null)
		dr["Email_Content"] = DBNull.Value;
		else
		dr["Email_Content"] = EmailContent;
		
		if (EmailUserType == null)
		dr["Email_UserType"] = DBNull.Value;
		else
		dr["Email_UserType"] = EmailUserType;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EmailId = dr["Email_Id"] != DBNull.Value ? Convert.ToInt32(dr["Email_Id"]) : EmailId = null;
		EmailTemplateId = dr["Email_TemplateId"] != DBNull.Value ? Convert.ToInt32(dr["Email_TemplateId"]) : EmailTemplateId = null;
		EmailType = dr["Email_Type"] != DBNull.Value ? Convert.ToString(dr["Email_Type"]) : EmailType = null;
		EmailSubject = dr["Email_Subject"] != DBNull.Value ? Convert.ToString(dr["Email_Subject"]) : EmailSubject = null;
		EmailContent = dr["Email_Content"] != DBNull.Value ? Convert.ToString(dr["Email_Content"]) : EmailContent = null;
		EmailUserType = dr["Email_UserType"] != DBNull.Value ? Convert.ToInt32(dr["Email_UserType"]) : EmailUserType = null;
	}
	
	public static TMSManageEmail[] MapFrom(DataSet ds)
	{
		List<TMSManageEmail> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSManageEmail>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ManageEmail] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ManageEmail] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSManageEmail instance = new TMSManageEmail();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSManageEmail Get(System.Int32 emailId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSManageEmail instance;
		
		
		instance = new TMSManageEmail();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emailId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSManageEmail ID:" + emailId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emailTemplateId, emailType, emailSubject, emailContent, emailUserType);
		
		if (transaction == null)
		this.EmailId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.EmailId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType)
	{
		Insert(emailTemplateId, emailType, emailSubject, emailContent, emailUserType, null);
	}
	/// <summary>
	/// Insert current TMSManageEmail to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EmailTemplateId, EmailType, EmailSubject, EmailContent, EmailUserType, transaction);
	}
	
	/// <summary>
	/// Insert current TMSManageEmail to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? emailId, System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@emailId"].Value = emailId;
		dbCommand.Parameters["@emailTemplateId"].Value = emailTemplateId;
		dbCommand.Parameters["@emailType"].Value = emailType;
		dbCommand.Parameters["@emailSubject"].Value = emailSubject;
		dbCommand.Parameters["@emailContent"].Value = emailContent;
		dbCommand.Parameters["@emailUserType"].Value = emailUserType;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? emailId, System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType)
	{
		Update(emailId, emailTemplateId, emailType, emailSubject, emailContent, emailUserType, null);
	}
	
	public static void Update(TMSManageEmail tMSManageEmail)
	{
		tMSManageEmail.Update();
	}
	
	public static void Update(TMSManageEmail tMSManageEmail, DbTransaction transaction)
	{
		tMSManageEmail.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSManageEmail_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@emailId"].SourceColumn = "Email_Id";
		dbCommand.Parameters["@emailTemplateId"].SourceColumn = "Email_TemplateId";
		dbCommand.Parameters["@emailType"].SourceColumn = "Email_Type";
		dbCommand.Parameters["@emailSubject"].SourceColumn = "Email_Subject";
		dbCommand.Parameters["@emailContent"].SourceColumn = "Email_Content";
		dbCommand.Parameters["@emailUserType"].SourceColumn = "Email_UserType";
		
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
	public static void Delete(System.Int32? emailId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emailId);
		
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
	public static void Delete(System.Int32? emailId)
	{
		Delete(
		emailId);
	}
	
	/// <summary>
	/// Delete current TMSManageEmail from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EmailId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EmailId = null;
	}
	
	/// <summary>
	/// Delete current TMSManageEmail from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSManageEmail[] Search(System.Int32? emailId, System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageEmail_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emailId, emailTemplateId, emailType, emailSubject, emailContent, emailUserType);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSManageEmail.MapFrom(ds);
	}
	
	
	public static TMSManageEmail[] Search(TMSManageEmail searchObject)
	{
		return Search ( searchObject.EmailId, searchObject.EmailTemplateId, searchObject.EmailType, searchObject.EmailSubject, searchObject.EmailContent, searchObject.EmailUserType);
	}
	
	/// <summary>
	/// Returns all TMSManageEmail objects.
	/// </summary>
	/// <returns>List of all TMSManageEmail objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSManageEmail[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

