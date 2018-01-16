import { ErrorHandler, Injectable } from "@angular/core";

@Injectable()

export class GlobalErrorHandler extends ErrorHandler{
    constructor() {
        super();
    }

    handleError(error: any) {
        let date = new Date();
        console.error('Error', {
            timestamp: date.toISOString(),
            message: error.message,
            zone: error.zone,
            task: error.task
        })
    }
}