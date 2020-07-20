import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { AppComponent }   from './components/app/app.component';
import { DataListComponent } from './components/data/dataList/data-list.component';
import { StatusSelectComponent } from './components/data/status/status.component';
import {TypeSelectComponent} from './components/data/type/type.component';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule }   from '@angular/forms';
// import {ActionComponent} from './components/app/action/download/action.component';
// import {UploadComponent} from './components/app/action/upload/upload.component';
// import {SharedModule} from './modules/shared.module';
// import {NgClassComponent} from './directivescomponent/ngclass.component';
// import { ChangestyleComponent } from './directivescomponent/changestyle.component';
// import {Changes} from  './directivescomponent/changestyles.component';
// import {BoldDirective} from './atributedirective/bold.directive';
// import {MyWhileDirective} from './StructureDirective/structure.directive';

@NgModule({
    imports:      [ BrowserModule, FormsModule, HttpClientModule, ReactiveFormsModule ],
    // imports: [BrowserModule],
    declarations: [ AppComponent, DataListComponent, StatusSelectComponent, TypeSelectComponent ],
    // declarations: [ AppComponent ],
    bootstrap:    [ AppComponent ]
    // exports: [
    //     SharedModule
    // ]
})
export class AppModule { }