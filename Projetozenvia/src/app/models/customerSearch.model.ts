import { Customer } from "./customer.model";

export interface CustomerSearch {
	Customers: Customer[],
  TotalCount: number
}
