import { NgModule } from "@angular/core";
import { DataListComponent } from '../components/data/dataList/data-list.component';
import { StatusSelectComponent } from '../components/data/status/status.component';
import {TypeSelectComponent} from '../components/data/type/type.component';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

// import {
//     MatFormFieldModule,
//     MatInputModule,
//     MatNativeDateModule,
//     MatIconModule,
//     MatDatepickerModule,
//     MatCheckboxModule,
//     MatSelectModule,
//     MatListModule,
//     MatDialogModule
// } from '@angular/material';
// import { NgxSpinnerModule } from '@hardpool/ngx-spinner';


@NgModule ({
    imports: [
        FormsModule,
        CommonModule,
        FormsModule,
        HttpClientModule,
        ReactiveFormsModule
    ],
    declarations:[
        DataListComponent,
        StatusSelectComponent,
        TypeSelectComponent
    ],
    exports:[
        DataListComponent,
        StatusSelectComponent,
        TypeSelectComponent
    ],
    providers: [],
})
export class SharedModule {}