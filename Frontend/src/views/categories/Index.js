import { useEffect, useState } from "react";
// node.js library that concatenates classes (strings)
import { Link } from "react-router-dom";
import {
  Alert,
  Button,
  Card,
  CardBody,
  CardHeader,
  Col,
  Container,
  Row,
  Table,
} from "reactstrap";
import categoryApi from "../../api/categoryApi.js";
import MyModal from "../../components/Customs/MyModal.js";
import Header from "../../components/Headers/Header.js";

const Categories = (props) => {
  const [categories, setCategories] = useState([{}]);

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

    var isDeleted = await categoryApi.deleteAsync(id);

    if (isDeleted) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: `Delete category ${deleteModal.content} successfully`,
      });

      // remove from list after delete successful
      var temp = [...categories];
      var removeIndex = temp.map((x) => x.Id).indexOf(id);

      temp.splice(removeIndex, 1);
      setCategories(temp);
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Delete category failed",
      });
    }

    setDeleteModal({
      isOpen: !deleteModal.isOpen,
      content: deleteModal.content,
      deleteId: deleteModal.id,
    });
  }
  async function refreshList() {
    var data = await categoryApi.getAllAsync();
    if (data) {
      setCategories(data);
    }
  }
  useEffect(() => {
    refreshList();
  }, []);
  return (
    <>
      <Header />
      <MyModal
        modal={deleteModal.isOpen}
        toggle={toggleDeleteModal}
        handler={deleteHandler}
        content={`Do you want to delete ${deleteModal.content}?`}
        color="danger"
        confirm="Delete"
      ></MyModal>
      {/* Page content */}
      <Container className="mt--7" fluid>
        <Row className="mt-5">
          <Col className="mb-5 mb-xl-0" xl="12">
            <Card className="shadow">
              <CardHeader className="border-0">
                <Row className="align-items-center">
                  <div className="col">
                    <h3 className="mb-0">All categories</h3>
                  </div>
                  <Link to="categories/create" className="mr-4">
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
                        #
                      </th>
                      <th width="30%" scope="col">
                        Name
                      </th>
                      <th scope="col">Description</th>
                      <th width="5%" scope="col">
                        Action
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {categories.map((category, index) => (
                      <tr key={category.Id + 1000}>
                        <td>{index + 1}</td>
                        <td>{category.Name}</td>
                        <td>{category.Description}</td>
                        <td>
                          <Link
                            to={`/admin/categories/${category.Id}/edit`}
                            className="mr-1"
                          >
                            <Button color="info">Edit</Button>
                          </Link>
                          {index > 7 && (
                            <>
                              <Button
                                color="danger"
                                onClick={() =>
                                  toggleDeleteModal(category.Id, category.Name)
                                }
                              >
                                Delete
                              </Button>
                            </>
                          )}
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </Table>
              </CardBody>
            </Card>
          </Col>
        </Row>
      </Container>
    </>
  );
};

export default Categories;
