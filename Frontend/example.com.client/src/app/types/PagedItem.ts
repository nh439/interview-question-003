export  interface PagedItem<T> {
  items: T[];
  totalItems: number;
  lastPage: number;
  hasData :boolean;
}
