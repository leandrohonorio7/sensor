import { NgModule } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';

import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';



@NgModule({
    imports: [
        MatButtonModule,
        MatToolbarModule,

        MatCardModule,
        MatIconModule,
        MatFormFieldModule,
        MatInputModule,
        MatPaginatorModule,
        MatTableModule,
        MatSortModule
    ],
    exports: [
        MatButtonModule,
        MatToolbarModule,
        MatPaginatorModule,
        MatTableModule,
        MatSortModule
    ],
    providers: [],
})
export class AppAngularMaterialModule {}
