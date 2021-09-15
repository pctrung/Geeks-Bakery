import { yupResolver } from "@hookform/resolvers/yup";
import { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
import { useHistory, useParams } from "react-router-dom";
import {
  Alert,
  Button,
  Card,
  CardBody,
  CardHeader,
  Col,
  Container,
  Form,
  FormGroup,
  Row,
} from "reactstrap";
import * as yup from "yup";
import categoryApi from "../../api/categoryApi.js";
import Header from "../../components/Headers/Header.js";

const CategoryEdit = (props) => {
  var { id } = useParams();
  let history = useHistory();

  const [category, setCategory] = useState({});

  const [stateMessage, setStateMessage] = useState({
    isOpen: false,
    color: "",
    message: "",
  });

  // yup validation
  const schema = yup.object().shape({
    Name: yup.string().required(),
    Description: yup.string().required(),
  });
  //react hook form
  const {
    register,
    handleSubmit,
    formState: { errors },
    reset,
  } = useForm({
    resolver: yupResolver(schema),
    defaultValues: category,
  });
  // handle submit
  const onSubmit = async (content) => {
    content.Id = id;
    if (
      category.Name !== content.Name ||
      category.Description !== content.Description
    ) {
      var data = await categoryApi.updateAsync(content);
      if (data) {
        setStateMessage({
          isOpen: true,
          color: "success",
          message: "Update category successfully",
        });

        setCategory(content);
        reset(content);
      } else {
        setStateMessage({
          isOpen: true,
          color: "danger",
          message: "Update category failed",
        });
      }
    } else {
      setStateMessage({
        isOpen: true,
        color: "warning",
        message: "Information is not changed",
      });
    }
  };
  async function refreshPage(id) {
    var data = await categoryApi.getByIdAsync(id);
    if (data) {
      setCategory(data);
      reset(data);
    }
  }
  useEffect(() => {
    refreshPage(id); // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  return (
    <>
      <Header />
      {/* Page content */}
      <Container className="mt--7" fluid>
        <Row className="mt-5">
          <Col className="mb-5 mb-xl-0" xl="12">
            <Card>
              <CardHeader>
                <Row className="align-items-center">
                  <div className="col">
                    <h3 className="mb-0">Category information</h3>
                  </div>
                  <Button
                    onClick={() => history.goBack()}
                    className="mr-4"
                    color="primary"
                  >
                    Back
                  </Button>
                </Row>
              </CardHeader>
              <CardBody className="pt-0 pt-md-4">
                <Alert
                  color={stateMessage.color}
                  isOpen={stateMessage.isOpen}
                  toggle={() => setStateMessage({ isOpen: false })}
                >
                  {stateMessage.message}
                </Alert>
                <Form onSubmit={handleSubmit(onSubmit)}>
                  <div className="pl-lg-4">
                    <Row>
                      <Col lg="4">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-cake-name"
                          >
                            Name
                          </label>
                          <input
                            className="form-control form-control-alternative"
                            id="input-cake-name"
                            placeholder="Category name"
                            type="text"
                            {...register("Name")}
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.Name?.message}
                          </div>
                        </FormGroup>
                      </Col>
                      <Col lg="8">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-category"
                          >
                            Description
                          </label>
                          <input
                            className="form-control form-control-alternative"
                            id="input-category"
                            type="text"
                            {...register("Description")}
                            placeholder="Short description"
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.Description?.message}
                          </div>
                        </FormGroup>
                        <FormGroup>
                          <Button className="float-right" color="success">
                            Save
                          </Button>
                          <Button
                            onClick={() => reset()}
                            className="float-right mr-2"
                            color="secondary"
                          >
                            Reset
                          </Button>
                        </FormGroup>
                      </Col>
                    </Row>
                  </div>
                </Form>
              </CardBody>
            </Card>
          </Col>
        </Row>
      </Container>
    </>
  );
};

export default CategoryEdit;
