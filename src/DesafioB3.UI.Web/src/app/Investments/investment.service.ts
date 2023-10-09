import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http"
import { Investment } from "./investment";
import { Observable } from "rxjs";

@Injectable()
export class InvestmentService {

    constructor (private http: HttpClient) {}

    protected UrlService: string = "https://localhost:7010/CalculateInvestment";

    CalculateInvestment(investment: Investment) : Observable<Investment> {
        return this.http.post<Investment>(this.UrlService, investment);
    }
}