﻿using Microsoft.AspNetCore.SignalR;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Api.Hubs
{
	public class StockTickerHub : Hub
	{
		private readonly StockTicker _stockTicker;

		public StockTickerHub(StockTicker stockTicker)
		{
			_stockTicker = stockTicker;
		}

		public IEnumerable<Stock> GetAllStocks()
		{
			return _stockTicker.GetAllStocks();
		}

		public IObservable<Stock> StreamStocks()
		{
			return _stockTicker.StreamStocks();
		}

		public string GetMarketState()
		{
			return _stockTicker.MarketState.ToString();
		}

		public async Task OpenMarket()
		{
			await _stockTicker.OpenMarket();
		}

		public async Task CloseMarket()
		{
			await _stockTicker.CloseMarket();
		}

		public async Task Reset()
		{
			await _stockTicker.Reset();
		}
	}
}
