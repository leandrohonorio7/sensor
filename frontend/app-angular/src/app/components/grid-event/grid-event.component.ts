import {AfterViewInit, Component, ViewChild, OnInit} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

@Component({
  selector: 'app-grid-event',
  templateUrl: './grid-event.component.html',
  styleUrls: ['./grid-event.component.css']
})

  export class GridEventComponent implements AfterViewInit, OnInit {
    displayedColumns: string[] = ['timestamp', 'tag', 'valor'];
    dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);
  
    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;
  
    ngAfterViewInit() {
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    }

    constructor() { }

    ngOnInit(): void {
    }
  }
  
  export interface PeriodicElement {
    timestamp: number;
    tag: string;
    valor: string;
  }
  
  const ELEMENT_DATA: PeriodicElement[] = [
    {timestamp: 1539112021301, tag: 'Hydrogen.Hydrogen.Hydrogen', valor:'H'},
    {timestamp: 1539112021301, tag: 'Helium.Helium.Helium', valor: 'He'},
    {timestamp: 1539112021301, tag: 'Lithium.Lithium.Lithium', valor: 'Li'},
    {timestamp: 1539112021301, tag: 'Beryllium.Beryllium.Beryllium', valor: 'Be'},
    {timestamp: 1539112021301, tag: 'Boron.Boron.Boron', valor: 'B'},
    {timestamp: 1539112021301, tag: 'Carbon.Carbon.Carbon', valor: 'C'},
    {timestamp: 1539112021301, tag: 'Nitrogen.Nitrogen.Nitrogen', valor: 'N'},
    {timestamp: 1539112021301, tag: 'Oxygen.Oxygen.Oxygen', valor: 'O'},
    {timestamp: 1539112021301, tag: 'Fluorine.Fluorine.Fluorine', valor: 'F'},
    {timestamp: 1539112021301, tag: 'Neon.Neon.Neon', valor: 'Ne'},
    {timestamp: 1539112021301, tag: 'Sodium.Sodium.Sodium', valor: 'Na'},
    {timestamp: 1539112021301, tag: 'Magnesium.Magnesium.Magnesium', valor: 'Mg'},
    {timestamp: 1539112021301, tag: 'Aluminum.Aluminum.Aluminum', valor: 'Al'},
    {timestamp: 1539112021301, tag: 'Silicon.Silicon.Silicon', valor: 'Si'},
    {timestamp: 1539112021301, tag: 'Phosphorus.Phosphorus.Phosphorus', valor: 'P'},
    {timestamp: 1539112021301, tag: 'Sulfur.Sulfur.Sulfur', valor: 'S'},
    {timestamp: 1539112021301, tag: 'Chlorine.Chlorine.Chlorine', valor: 'Cl'},
    {timestamp: 1539112021301, tag: 'Argon.Argon.Argon', valor: 'Ar'},
    {timestamp: 1539112021301, tag: 'Potassium.Potassium.Potassium', valor: 'K'},
    {timestamp: 1539112021301, tag: 'Calcium.Calcium.Calcium', valor: 'Ca'},
  ];