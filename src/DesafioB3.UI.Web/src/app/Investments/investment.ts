export class Investment{
    initialAmount: number;
    months: number;
    grossResult: number;
    netResult: number;

    constructor(
        initialAmount: number,
        months: number,
        grossResult: number,
        netResult: number
    ) {
        this.initialAmount = initialAmount;
        this.months = months;
        this.grossResult = grossResult;
        this.netResult = netResult;
    }
}