import { useState, useEffect } from "react";
// reactstrap components
import {
  Card,
  CardHeader,
  Table,
  Container,
  Row,
  Col,
  CardBody,
} from "reactstrap";

import Header from "../../components/Headers/Header.js";
import MyPagination from "../../components/Customs/MyPagination.js";

import userApi from "../../api/userApi.js";

const defaultLimit = 10;

const Users = (props) => {
  const [users, setUsers] = useState([{}]);

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
    var data = await userApi.getAllAsync(pagination);
    if (data) {
      setUsers(data.items);
      setPagination({
        page: data.page,
        limit: data.limit,
        pageCount: data.pageCount,
      });
    }
  }
  useEffect(() => {
    refreshList({ page: 1, limit: defaultLimit, keyword: "" });
  }, []);

  return (
    <>
      <Header />
      {/* Page content */}
      <Container className="mt--7" fluid>
        <Row className="mt-5">
          <Col className="mb-5 mb-xl-0" xl="12">
            <Card className="shadow">
              <CardHeader className="border-0">
                <Row className="align-items-center">
                  <div className="col">
                    <h3 className="mb-0">All users</h3>
                  </div>
                </Row>
              </CardHeader>
              <CardBody>
                <Table className="align-items-center table-flush" responsive>
                  <thead className="thead-light">
                    <tr>
                      <th width="1%" scope="col">
                        #
                      </th>
                      <th scope="col">Id</th>
                      <th scope="col">Username</th>
                      <th scope="col">Name</th>
                      <th scope="col">Email</th>
                      <th scope="col">Phone Number</th>
                    </tr>
                  </thead>
                  <tbody>
                    {users.map((user, index) => (
                      <tr key={index}>
                        <td>
                          {index +
                            1 +
                            (pagination.page > 1
                              ? (pagination.page - 1) * 10
                              : 0)}
                        </td>
                        <td>{user.id}</td>
                        <td>{user.userName}</td>
                        <td>{user.name}</td>
                        <td>{user.email}</td>
                        <td>{user.phoneNumber}</td>
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

export default Users;
