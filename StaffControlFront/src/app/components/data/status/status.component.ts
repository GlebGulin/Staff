import { Component, OnInit, ViewChild } from '@angular/core';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { StatusModel } from '../../../models/status-model.model';
import {LoadService} from '../../../services/data/load-data.service';


@Component({
    selector: 'status-select',
    templateUrl: './status.component.html',
    styleUrls: ['./status.component.css'],
    providers: [LoadService]
})

export class StatusSelectComponent implements OnInit {
    

    statusModel:StatusModel[]=[];
    constructor(private http: LoadService){}
    ngOnInit(){
        this.http.getData().subscribe(data => this.statusModel=data["item2"]);
    }
}