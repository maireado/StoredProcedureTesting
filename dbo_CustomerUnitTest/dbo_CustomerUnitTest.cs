using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dbo_CustomerUnitTest
{
	[TestClass()]
	public class dbo_CustomerUnitTest : SqlDatabaseTestClass
	{

		public dbo_CustomerUnitTest()
		{
			InitializeComponent();
		}

		[TestInitialize()]
		public void TestInitialize()
		{
			base.InitializeTest();
		}
		[TestCleanup()]
		public void TestCleanup()
		{
			base.CleanupTest();
		}

		#region Designer support code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CustomerTest_TestAction;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbo_CustomerUnitTest));
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CustomerInvalidParamsReturns0Rows_TestAction;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CustomerNullParamReturns0Rows_TestAction;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction;
			Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
			this.dbo_CustomerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
			this.dbo_CustomerInvalidParamsReturns0RowsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
			this.dbo_CustomerNullParamReturns0RowsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
			this.dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
			dbo_CustomerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
			notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
			rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
			scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
			scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
			executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
			dbo_CustomerInvalidParamsReturns0Rows_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
			rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
			dbo_CustomerNullParamReturns0Rows_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
			rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
			dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
			rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
			// 
			// dbo_CustomerTest_TestAction
			// 
			dbo_CustomerTest_TestAction.Conditions.Add(notEmptyResultSetCondition1);
			dbo_CustomerTest_TestAction.Conditions.Add(rowCountCondition1);
			dbo_CustomerTest_TestAction.Conditions.Add(scalarValueCondition1);
			dbo_CustomerTest_TestAction.Conditions.Add(scalarValueCondition2);
			dbo_CustomerTest_TestAction.Conditions.Add(executionTimeCondition1);
			resources.ApplyResources(dbo_CustomerTest_TestAction, "dbo_CustomerTest_TestAction");
			// 
			// notEmptyResultSetCondition1
			// 
			notEmptyResultSetCondition1.Enabled = true;
			notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
			notEmptyResultSetCondition1.ResultSet = 1;
			// 
			// rowCountCondition1
			// 
			rowCountCondition1.Enabled = true;
			rowCountCondition1.Name = "rowCountCondition1";
			rowCountCondition1.ResultSet = 1;
			rowCountCondition1.RowCount = 2;
			// 
			// scalarValueCondition1
			// 
			scalarValueCondition1.ColumnNumber = 1;
			scalarValueCondition1.Enabled = true;
			scalarValueCondition1.ExpectedValue = "John";
			scalarValueCondition1.Name = "scalarValueCondition1";
			scalarValueCondition1.NullExpected = false;
			scalarValueCondition1.ResultSet = 1;
			scalarValueCondition1.RowNumber = 1;
			// 
			// scalarValueCondition2
			// 
			scalarValueCondition2.ColumnNumber = 2;
			scalarValueCondition2.Enabled = true;
			scalarValueCondition2.ExpectedValue = "Beaver";
			scalarValueCondition2.Name = "scalarValueCondition2";
			scalarValueCondition2.NullExpected = false;
			scalarValueCondition2.ResultSet = 1;
			scalarValueCondition2.RowNumber = 1;
			// 
			// executionTimeCondition1
			// 
			executionTimeCondition1.Enabled = true;
			executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:50");
			executionTimeCondition1.Name = "executionTimeCondition1";
			// 
			// dbo_CustomerInvalidParamsReturns0Rows_TestAction
			// 
			dbo_CustomerInvalidParamsReturns0Rows_TestAction.Conditions.Add(rowCountCondition2);
			resources.ApplyResources(dbo_CustomerInvalidParamsReturns0Rows_TestAction, "dbo_CustomerInvalidParamsReturns0Rows_TestAction");
			// 
			// rowCountCondition2
			// 
			rowCountCondition2.Enabled = true;
			rowCountCondition2.Name = "rowCountCondition2";
			rowCountCondition2.ResultSet = 1;
			rowCountCondition2.RowCount = 0;
			// 
			// dbo_CustomerNullParamReturns0Rows_TestAction
			// 
			dbo_CustomerNullParamReturns0Rows_TestAction.Conditions.Add(rowCountCondition3);
			resources.ApplyResources(dbo_CustomerNullParamReturns0Rows_TestAction, "dbo_CustomerNullParamReturns0Rows_TestAction");
			// 
			// rowCountCondition3
			// 
			rowCountCondition3.Enabled = true;
			rowCountCondition3.Name = "rowCountCondition3";
			rowCountCondition3.ResultSet = 1;
			rowCountCondition3.RowCount = 0;
			// 
			// dbo_CustomerTestData
			// 
			this.dbo_CustomerTestData.PosttestAction = null;
			this.dbo_CustomerTestData.PretestAction = null;
			this.dbo_CustomerTestData.TestAction = dbo_CustomerTest_TestAction;
			// 
			// dbo_CustomerInvalidParamsReturns0RowsData
			// 
			this.dbo_CustomerInvalidParamsReturns0RowsData.PosttestAction = null;
			this.dbo_CustomerInvalidParamsReturns0RowsData.PretestAction = null;
			this.dbo_CustomerInvalidParamsReturns0RowsData.TestAction = dbo_CustomerInvalidParamsReturns0Rows_TestAction;
			// 
			// dbo_CustomerNullParamReturns0RowsData
			// 
			this.dbo_CustomerNullParamReturns0RowsData.PosttestAction = null;
			this.dbo_CustomerNullParamReturns0RowsData.PretestAction = null;
			this.dbo_CustomerNullParamReturns0RowsData.TestAction = dbo_CustomerNullParamReturns0Rows_TestAction;
			// 
			// dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData
			// 
			this.dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData.PosttestAction = null;
			this.dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData.PretestAction = null;
			this.dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData.TestAction = dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction;
			// 
			// dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction
			// 
			dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction.Conditions.Add(rowCountCondition4);
			resources.ApplyResources(dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction, "dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount_TestAction");
			// 
			// rowCountCondition4
			// 
			rowCountCondition4.Enabled = true;
			rowCountCondition4.Name = "rowCountCondition4";
			rowCountCondition4.ResultSet = 1;
			rowCountCondition4.RowCount = 1;
		}

		#endregion


		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		#endregion

		[TestMethod()]
		public void dbo_CustomerValidParamsReturnsNonEmptyResultSet()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerTestData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		[TestMethod()]
		public void dbo_CustomerValidParamsReturnsCorrectRowCount()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerTestData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		[TestMethod()]
		public void dbo_CustomerValidParamsReturnsExpectedColumn1Value()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerTestData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		[TestMethod()]
		public void dbo_CustomerTestValidParamsReturnsExpectedColumn2Value()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerTestData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		[TestMethod()]
		public void dbo_CustomerValidParamsExecutionTimeIsBelowThreshold()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerTestData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		
		[TestMethod()]
		public void dbo_CustomerInvalidParamsReturns0Rows()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerInvalidParamsReturns0RowsData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		

		[TestMethod()]
		public void dbo_CustomerNullParamReturns0Rows()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerNullParamReturns0RowsData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}
		
		[TestMethod()]
		public void dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCount()
		{
			SqlDatabaseTestActions testActions = this.dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData;
			// Execute the pre-test script
			// 
			System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
			SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
			try
			{
				// Execute the test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
				SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
			}
			finally
			{
				// Execute the post-test script
				// 
				System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
				SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
			}
		}



		private SqlDatabaseTestActions dbo_CustomerTestData;
		private SqlDatabaseTestActions dbo_CustomerInvalidParamsReturns0RowsData;
		private SqlDatabaseTestActions dbo_CustomerNullParamReturns0RowsData;
		private SqlDatabaseTestActions dbo_CustomerFirstNameNVarChar50ReturnsCorrectRowCountData;
	}
}
