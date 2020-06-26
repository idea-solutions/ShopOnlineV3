export interface Category {
  id	: string;
  name:	string;
  categoryParent :	number;
  subCategoryId : string;
  categoryDataParent : 	Category;
  listChilds : 	Category[];
  products : [];
}
