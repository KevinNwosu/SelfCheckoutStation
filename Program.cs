using SelfCheckoutStation;

Configuration c = new Configuration(ConsoleIO.GetSalesTax());
SelfCheckoutStationWorkflow till = new SelfCheckoutStationWorkflow();
till.Run(c);