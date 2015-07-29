using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTestimonialsEduGist
{
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet GetSearch(System.Int64? tsId, System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tsId, tsName, tsPhotopath, tsTestimonials, tsDate, tsStatus);
		
		return db.ExecuteDataSet(dbCommand);
		
	}


    public static DataSet GetSearch(TMSTestimonialsEduGist searchObject)
	{
        return GetSearch(searchObject.TsId, searchObject.TSName, searchObject.TSPhotopath, searchObject.TSTestimonials, searchObject.TSDate, searchObject.TSStatus);
	}
	
	/// <summary>
	/// Returns all TMSTestimonialsEduGist objects.
	/// </summary>
	/// <returns>List of all TMSTestimonialsEduGist objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
	{
        return GetSearch(null, null, null, null, null, null);
	}
	
	#endregion
}

