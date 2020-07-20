import { Component, OnInit, ViewChild } from '@angular/core';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { DataModel } from '../../../models/data-model.model';
import {LoadService} from '../../../services/data/load-data.service';


@Component({
    selector: 'data-list',
    templateUrl: './data-list.component.html',
    styleUrls: ['./data-list.component.css'],
    providers: [LoadService]
})

export class DataListComponent implements OnInit  {
    

    dataModel:DataModel[]=[];
    constructor(private http: LoadService){}
    ngOnInit(){
        this.http.getData().subscribe(data => this.dataModel=data["item1"]);
    }
}