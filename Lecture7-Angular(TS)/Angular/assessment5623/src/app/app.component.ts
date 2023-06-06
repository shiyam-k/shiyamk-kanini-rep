import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  res : string = ''
  baseCurrency: string = '';
  targetCurrency: string = '';
  amount: number = 0;
  convertedAmount: number = 0;
  currenciesAndValues = [
    {
      country: 'United States',
      currency: 'USD',
      rates: 1
    },
    {
      country: 'Canada',
      currency: 'CAD',
      rates: 0.82 // 1 USD = 0.82 CAD
    },
    {
      country: 'United Kingdom',
      currency: 'GBP',
      rates: 1.41 // 1 USD = 1.41 GBP
    },
    {
      country: 'Australia',
      currency: 'AUD',
      rates: 0.75 // 1 USD = 0.75 AUD
    },
    {
      country: 'Japan',
      currency: 'JPY',
      rates: 0.0092 // 1 USD = 0.0092 JPY
    },
    {
      country: 'Eurozone',
      currency: 'EUR',
      rates: 1.22 // 1 USD = 1.22 EUR
    },
    {
      country: 'Switzerland',
      currency: 'CHF',
      rates: 1.09 // 1 USD = 1.09 CHF
    },
    {
      country: 'New Zealand',
      currency: 'NZD',
      rates: 0.71 // 1 USD = 0.71 NZD
    },
    {
      country: 'India',
      currency: 'INR',
      rates: 82.59 // 1 USD = 82.59 INR
    },
    {
      country: 'China',
      currency: 'CNY',
      rates: 0.16 // 1 USD = 0.16 CNY
    }    
  ]
  

  // constructor(private http: HttpClient) {}

  convertCurrency() {
    if (!this.baseCurrency || !this.targetCurrency || !this.amount) {
      this.res = "Input Fields are empty";
      document.querySelector('.res')?.classList.remove('text-success');
      document.querySelector('.res')?.classList.add('text-danger');
    } else {
      document.querySelector('.res')?.classList.remove('text-danger');
      const baseCurrencyValue = this.currenciesAndValues.find(c => c.currency === this.baseCurrency)?.rates;
      const targetCurrencyValue = this.currenciesAndValues.find(c => c.currency === this.targetCurrency)?.rates;
  
      if (baseCurrencyValue && targetCurrencyValue) {
        this.convertedAmount = (this.amount / baseCurrencyValue) * targetCurrencyValue;
        this.res = this.baseCurrency +" to " + this.targetCurrency;
        document.querySelector('.res')?.classList.add('text-success');
      } else {
        this.res = "Error";
        document.querySelector('.res')?.classList.remove('text-success');
        document.querySelector('.res')?.classList.add('text-danger');
      }
    }
  }
  

  //   const url = `https://api.exchangerate-api.com/v4/latest/${this.baseCurrency}`;

  //   this.http.get(url).subscribe((data: any) => {
  //     const rates = data.rates;
  //     const conversionRate = rates[this.targetCurrency];

  //     if (conversionRate) {
  //       this.convertedAmount = this.amount * conversionRate;
  //     } else {
  //       console.error('Invalid target currency');
  //     }
  //   }, (error) => {
  //     console.error('Failed to fetch exchange rates', error);
  //   });
  // }
}
