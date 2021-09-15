import { yupResolver } from "@hookform/resolvers/yup";
import { useEffect, useState } from "react";
import { useForm, useWatch } from "react-hook-form";
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
import cakeApi from "../../api/cakeApi.js";
import categoryApi from "../../api/categoryApi.js";
import Header from "../../components/Headers/Header.js";
import ImageCreate from "../../components/Images/ImageCreate.js";
import ImageUpdate from "../../components/Images/ImageUpdate.js";

export default function CakeEdit(props) {
  var { id } = useParams();
  let history = useHistory();

  const [cake, setCake] = useState({});
  const [categories, setCategories] = useState([]);
  const [isChanged, setIsChanged] = useState(false);

  const [stateMessage, setStateMessage] = useState({
    isOpen: false,
    color: "",
    message: "",
  });

  // yup validation
  const schema = yup.object().shape({
    Name: yup.string().required(),
    CategoryId: yup.number().required(),
    Price: yup.number().required().positive().integer(),
    OriginalPrice: yup.number().required().positive().integer(),
    Size: yup.number().required().positive().integer(),
    Slug: yup.string().required(),
    Description: yup.string().required(),
  });

  // react  hook form
  const {
    register,
    handleSubmit,
    control,
    formState: { errors },
    reset,
  } = useForm({
    resolver: yupResolver(schema),
    defaultValues: cake,
  });
  // handle submit
  const onSubmit = async (content) => {
    content.Id = id;

    if (
      cake.Name !== content.Name ||
      cake.Description !== content.Description ||
      cake.CategoryId !== content.CategoryId ||
      cake.Price !== content.Price ||
      cake.OriginalPrice !== content.OriginalPrice ||
      cake.Size !== content.Size ||
      cake.Slug !== content.Slug
    ) {
      var data = await cakeApi.updateAsync(content);
      if (data) {
        setStateMessage({
          isOpen: true,
          color: "success",
          message: "Update cake successfully",
        });

        setCake(content);
        reset(content);
      } else {
        setStateMessage({
          isOpen: true,
          color: "danger",
          message: "Update cake failed",
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

  // use on first load
  async function refreshPage(id) {
    var categoryResult = await categoryApi.getAllAsync();
    if (categoryResult) {
      setCategories(categoryResult);
    }
    var cakeResult = await cakeApi.getByIdAsync(id);
    if (cakeResult) {
      setCake(cakeResult);
      reset(cakeResult);
    }
  }

  const watchInfo = useWatch({
    control,
  });
  function onUpdateChange() {
    var result = false;
    if (watchInfo) {
      result =
        watchInfo.Name !== cake.Name ||
        watchInfo.Price !== cake.Price ||
        watchInfo.OriginalPrice !== cake.OriginalPrice ||
        watchInfo.Description !== cake.Description ||
        watchInfo.Slug !== cake.Slug ||
        watchInfo.Size !== cake.Size ||
        watchInfo.CategoryId !== cake.CategoryId;
    }
    setIsChanged(result);
  }

  useEffect(() => {
    refreshPage(id); // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  useEffect(() => {
    onUpdateChange(); // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [watchInfo]);

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
                    <h3 className="mb-0">Cake information</h3>
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
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-cake-name"
                          >
                            Name
                          </label>

                          <input
                            className="form-control-alternative form-control"
                            id="input-cake-name"
                            placeholder="Cake name"
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
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-category"
                          >
                            Category
                          </label>
                          <select
                            className="form-control-alternative form-control"
                            id="input-category"
                            type="select"
                            {...register("CategoryId")}
                          >
                            {categories.map((category) => (
                              <option key={category.Id} value={category.Id}>
                                {category.Name}
                              </option>
                            ))}
                          </select>
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.CategoryId?.message}
                          </div>
                        </FormGroup>
                      </Col>
                    </Row>
                    <Row>
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-price"
                          >
                            Price
                          </label>
                          <input
                            className="form-control-alternative form-control"
                            id="input-price"
                            placeholder="Cake price"
                            {...register("Price")}
                            type="number"
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.Price?.message}
                          </div>
                        </FormGroup>
                      </Col>
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-original-price"
                          >
                            Original Price
                          </label>
                          <input
                            className="form-control-alternative form-control"
                            id="input-original-price"
                            placeholder="Cake original price"
                            {...register("OriginalPrice")}
                            type="number"
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.OriginalPrice?.message}
                          </div>
                        </FormGroup>
                      </Col>
                    </Row>
                    <Row>
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-seo"
                          >
                            SEO Name
                          </label>
                          <input
                            className="form-control-alternative form-control"
                            id="input-seo"
                            placeholder="Ex: round-chocolate-truffle-cake"
                            {...register("Slug")}
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.Slug?.message}
                          </div>
                        </FormGroup>
                      </Col>
                      <Col lg="6">
                        <FormGroup>
                          <label
                            className="form-control-label"
                            htmlFor="input-cake-size"
                          >
                            Size (cm)
                          </label>
                          <input
                            className="form-control-alternative form-control"
                            id="input-cake-size"
                            placeholder="Ex: 23"
                            {...register("Size")}
                            type="number"
                          />
                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {errors.Size?.message}
                          </div>
                        </FormGroup>
                      </Col>
                    </Row>
                  </div>
                  <div className="pl-lg-4">
                    <FormGroup>
                      <label>Description</label>
                      <textarea
                        className="form-control-alternative form-control"
                        placeholder="A few words about this cake ..."
                        rows="4"
                        type="textarea"
                        {...register("Description")}
                      />
                      <div
                        style={{ fontSize: 13 }}
                        className="text-danger fw-light mx-1 mt-2"
                      >
                        {errors.Description?.message}
                      </div>
                    </FormGroup>
                    <FormGroup>
                      <Button
                        disabled={!isChanged}
                        className="float-right"
                        color="success"
                      >
                        Update
                      </Button>
                      <Button
                        onClick={() => reset()}
                        className="float-right mr-2"
                        color="secondary"
                        disabled={!isChanged}
                      >
                        Reset
                      </Button>
                    </FormGroup>
                  </div>
                </Form>
              </CardBody>
            </Card>
          </Col>
        </Row>
        {cake.CakeImages && (
          <ImageUpdate
            cakeId={cake.Id}
            cakeImages={cake.CakeImages}
            refreshPage={refreshPage}
          ></ImageUpdate>
        )}
        <ImageCreate cakeId={id} refreshPage={refreshPage}></ImageCreate>
      </Container>
    </>
  );
}
