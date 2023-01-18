﻿using OoplesFinance.YahooFinanceAPI;
using OoplesFinance.YahooFinanceAPI.Enums;

var startDate = DateTime.Now.AddYears(-1);
var symbol = "AAPL";

var yahooClient = new YahooClient();
//var historicalDataList = await yahooClient.GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
//var capitalGainList = await yahooClient.GetCapitalGainDataAsync(symbol, DataFrequency.Monthly, startDate);
//var dividendList = await yahooClient.GetDividendDataAsync(symbol, DataFrequency.Weekly, startDate);
//var stockSplitList = await yahooClient.GetStockSplitDataAsync(symbol, DataFrequency.Monthly, startDate);
var topTrendingList = await yahooClient.GetTopTrendingStocksAsync(Country.UnitedStates, 10);
var recommendedList = await yahooClient.GetStockRecommendationsAsync(symbol);
var keyStatsList = await yahooClient.GetKeyStatisticsAsync(symbol);
var summaryDetailsList = await yahooClient.GetSummaryDetailsAsync(symbol);
var insiderHoldersList = await yahooClient.GetInsiderHoldersAsync(symbol);
var insiderTransactionsList = await yahooClient.GetInsiderTransactionsAsync(symbol);
var financialDataList = await yahooClient.GetFinancialDataAsync(symbol);
var institutionOwnershipList = await yahooClient.GetInstitutionOwnershipAsync(symbol);
var fundOwnershipList = await yahooClient.GetFundOwnershipAsync(symbol);
var majorDirectHoldersList = await yahooClient.GetMajorDirectHoldersAsync(symbol);
var secFilingsList = await yahooClient.GetSecFilingsAsync(symbol);
//var insightsList = await yahooClient.GetInsightsAsync(symbol);
var majorHoldersBreakdownList = await yahooClient.GetMajorHoldersBreakdownAsync(symbol);
var upgradeDowngradeHistoryList = await yahooClient.GetUpgradeDowngradeHistoryAsync(symbol);
var esgScoresList = await yahooClient.GetEsgScoresAsync(symbol);
var recommendationTrendList = await yahooClient.GetRecommendationTrendAsync(symbol);
var indexTrendList = await yahooClient.GetIndexTrendAsync(symbol);
var sectorTrendList = await yahooClient.GetSectorTrendAsync(symbol);
var earningsTrendList = await yahooClient.GetEarningsTrendAsync(symbol);
var assetProfileList = await yahooClient.GetAssetProfileAsync(symbol);
var fundProfileList = await yahooClient.GetFundProfileAsync("VSMPX");
var calendarEventsList = await yahooClient.GetCalendarEventsAsync(symbol);
var earningsList = await yahooClient.GetEarningsAsync(symbol);
var balanceSheetHistoryList = await yahooClient.GetBalanceSheetHistoryAsync(symbol);
var cashflowStatementHistoryList = await yahooClient.GetCashflowStatementHistoryAsync(symbol);
var incomeStatementHistoryList = await yahooClient.GetIncomeStatementHistoryAsync(symbol);
var earningsHistoryList = await yahooClient.GetEarningsHistoryAsync(symbol);
var quoteTypeList = await yahooClient.GetQuoteTypeAsync(symbol);
var priceList = await yahooClient.GetPriceInfoAsync(symbol);
var netSharePurchaseActivityList = await yahooClient.GetNetSharePurchaseActivityAsync(symbol);
var incomeStatementHistoryQuarterlyList = await yahooClient.GetIncomeStatementHistoryQuarterlyAsync(symbol);

Console.WriteLine();