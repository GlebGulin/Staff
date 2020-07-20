import { Component, OnInit, ViewChild } from '@angular/core';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { TypeModel } from '../../../models/type-model.model';
import {LoadService} from '../../../services/data/load-data.service';


@Component({
    selector: 'type-select',
    templateUrl: './type.component.html',
    styleUrls: ['./type.component.css'],
    providers: [LoadService]
})

export class TypeSelectComponent implements OnInit  {
    

    typeModel:TypeModel[]=[];
    constructor(private http: LoadService){}
    ngOnInit(){
        this.http.getData().subscribe(data => this.typeModel=data["item3"]);
    }
}