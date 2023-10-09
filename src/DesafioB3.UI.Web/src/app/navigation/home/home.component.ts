import { Component } from '@angular/core';
import { Investment } from 'src/app/Investments/investment';
import { InvestmentService } from 'src/app/Investments/investment.service';

@Component({
  selector: 'app-home',
  templateUrl: 'home.component.html'
})

export class HomeComponent {
  investment: Investment = new Investment(0, 0, 0, 0);
  result!: Investment;

  constructor(private investmentService: InvestmentService){}

  onSubmit(){
    this.investmentService
      .CalculateInvestment(this.investment)
      .subscribe((response) => {
        this.result = response;
      })
  }
}
