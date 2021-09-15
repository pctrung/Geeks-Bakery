import { Pagination, PaginationItem } from "reactstrap";
import "./MyPagination.css";

export default function MyPagination(props) {
  const { pagination, onPageChange } = props;
  const { page, pageCount } = pagination;

  var numPages = [];
  for (var i = 1; i <= pageCount; i++) {
    numPages.push(i);
  }

  function handlePageChange(newPage) {
    if (onPageChange) {
      if (newPage <= pageCount && newPage >= 1) {
        onPageChange(newPage);
      }
    }
  }
  return (
    <>
      <Pagination>
        <PaginationItem
          className="page__btn"
          disabled={page <= 1}
          onClick={() => handlePageChange(page - 1)}
        >
          {"<"}
        </PaginationItem>
        {numPages.map((numPage) => (
          <PaginationItem
            key={numPage}
            active={page === numPage}
            onClick={() => handlePageChange(numPage)}
          >
            {numPage}
          </PaginationItem>
        ))}
        <PaginationItem
          className="page__btn"
          disabled={page >= pageCount}
          onClick={() => handlePageChange(page + 1)}
        >
          {">"}
        </PaginationItem>
      </Pagination>
    </>
  );
}
