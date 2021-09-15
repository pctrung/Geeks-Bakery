import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import {
  Button,
  Card,
  CardHeader,
  Table,
  Container,
  Row,
  Col,
  Alert,
  CardBody,
} from "reactstrap";

import Header from "../../components/Headers/Header.js";
import MyModal from "../../components/Customs/MyModal.js";

import MyPagination from "../../components/Customs/MyPagination.js";

import cakeApi from "../../api/cakeApi.js";

const defaultLimit = 10;

const Cakes = (props) => {
  const [cakes, setCakes] = useState([]);

  // alert message
  const [stateMessage, setStateMessage] = useState({
    isOpen: false,
    color: "",
    message: "",
  });

  // delete feature
  const [deleteModal, setDeleteModal] = useState({
    isOpen: false,
    content: "",
    deleteId: 0,
  });

  function toggleDeleteModal(id = 0, name = "") {
    if (id !== 0 && name !== "") {
      setDeleteModal({
        isOpen: !deleteModal.isOpen,
        content: name,
        deleteId: id,
      });
    } else {
      setDeleteModal({
        isOpen: !deleteModal.isOpen,
        content: deleteModal.content,
        deleteId: deleteModal.deleteId,
      });
    }
  }

  async function deleteHandler() {
    var id = deleteModal.deleteId;

    var isDeleted = await cakeApi.deleteAsync(id);
    if (isDeleted) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: `Delete cake ${deleteModal.content} successfully`,
      });

      // remove from list after delete successful
      var temp = [...cakes];
      var removeIndex = temp.map((x) => x.Id).indexOf(id);

      temp.splice(removeIndex, 1);
      setCakes(temp);
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Delete cake failed",
      });
    }

    setDeleteModal({
      isOpen: !deleteModal.isOpen,
      content: deleteModal.content,
      deleteId: deleteModal.id,
    });
  }

  // pagination
  const [pagination, setPagination] = useState({
    page: 1,
    limit: defaultLimit,
    pageCount: 1,
  });
  function handlePageChange(newPage) {
    refreshList({ page: newPage, limit: defaultLimit, keyword: "" });
  }
  async function refreshList(pagination) {
    var data = await cakeApi.getAllAsync(pagination);
    if (data) {
      setCakes(data.Items);
      setPagination({
        page: data.Page,
        limit: data.Limit,
        pageCount: data.PageCount,
      });
    }
  }

  useEffect(() => {
    refreshList({ page: 1, limit: defaultLimit, keyword: "" });
  }, []);
  return (
    <>
      <MyModal
        modal={deleteModal.isOpen}
        toggle={toggleDeleteModal}
        handler={deleteHandler}
        content={`Do you want to delete ${deleteModal.content}?`}
        color="danger"
        confirm="Delete"
      ></MyModal>
      <Header />
      {/* Page content */}
      <Container className="mt--7" fluid>
        <Row className="mt-5">
          <Col className="mb-5 mb-xl-0" xl="12">
            <Card className="shadow">
              <CardHeader className="border-0">
                <Row className="align-items-center">
                  <div className="col">
                    <h3 className="mb-0">All cakes</h3>
                  </div>
                  <Link to="/admin/cakes/create" className="mr-4">
                    <Button color="success">Add</Button>
                  </Link>
                </Row>
              </CardHeader>
              <CardBody>
                <Alert
                  color={stateMessage.color}
                  isOpen={stateMessage.isOpen}
                  toggle={() => setStateMessage({ isOpen: false })}
                >
                  {stateMessage.message}
                </Alert>
                <Table className="align-items-center table-flush" responsive>
                  <thead className="thead-light">
                    <tr>
                      <th width="5%" scope="col">
                        Id
                      </th>
                      <th scope="col">Name</th>
                      <th scope="col">Category</th>
                      <th scope="col">Price</th>
                      <th scope="col">Original Price</th>
                      <th scope="col">Image</th>
                      <th scope="col">Created Date</th>
                      <th scope="col">Updated Date</th>
                      <th width="10%" scope="col">
                        Action
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {cakes.map((cake) => (
                      <tr key={cake.Id + 1000}>
                        <td>#{cake.Id}</td>
                        <td>{cake.Name}</td>
                        <td>{cake.CategoryName}</td>
                        <td>{cake.Price}</td>
                        <td>{cake.OriginalPrice}</td>
                        <td>
                          {cake.CakeImages?.length > 0 ? (
                            <img
                              className="img-thumbnail rounded"
                              style={{ width: 100 }}
                              src={cake.CakeImages[0].FileUrl}
                              alt={cake.CakeImages[0].Caption}
                            />
                          ) : (
                            "Don't have any images"
                          )}
                        </td>
                        <td>
                          {new Date(Date.parse(cake.DateCreated)).getDate() +
                            "-" +
                            (new Date(Date.parse(cake.DateCreated)).getMonth() +
                              1) +
                            "-" +
                            new Date(
                              Date.parse(cake.DateCreated),
                            ).getFullYear() +
                            " " +
                            new Date(Date.parse(cake.DateCreated)).getHours() +
                            ":" +
                            new Date(Date.parse(cake.DateCreated)).getMinutes()}
                        </td>
                        <td>
                          {cake.DateModified
                            ? new Date(
                                Date.parse(cake.DateModified),
                              ).getDate() +
                              "-" +
                              (new Date(
                                Date.parse(cake.DateModified),
                              ).getMonth() +
                                1) +
                              "-" +
                              new Date(
                                Date.parse(cake.DateModified),
                              ).getFullYear() +
                              " " +
                              new Date(
                                Date.parse(cake.DateModified),
                              ).getHours() +
                              ":" +
                              new Date(
                                Date.parse(cake.DateModified),
                              ).getMinutes()
                            : "Haven't updated yet"}
                        </td>
                        <td>
                          <Link
                            className="mr-1"
                            to={`/admin/cakes/${cake.Id}/edit`}
                          >
                            <Button color="info">Edit</Button>
                          </Link>
                          <Button
                            onClick={() =>
                              toggleDeleteModal(cake.Id, cake.Name)
                            }
                            color="danger"
                          >
                            Delete
                          </Button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </Table>
                <MyPagination
                  pagination={pagination}
                  onPageChange={handlePageChange}
                />
              </CardBody>
            </Card>
          </Col>
        </Row>
      </Container>
    </>
  );
};

export default Cakes;
