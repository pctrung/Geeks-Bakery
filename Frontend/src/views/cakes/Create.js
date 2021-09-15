import { yupResolver } from "@hookform/resolvers/yup";
import { useEffect, useState } from "react";
import { useForm, useFieldArray } from "react-hook-form";
import { useHistory } from "react-router-dom";
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
import imageApi from "../../api/imageApi.js";
import categoryApi from "../../api/categoryApi.js";
import Header from "../../components/Headers/Header.js";

const CakeCreate = (props) => {
  let history = useHistory();

  const [categories, setCategories] = useState([]);
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
    Images: yup.array().of(
      yup.object().shape({
        ImageFile: yup
          .mixed()
          .required()
          .test("fileFormat", "You can only upload image files", (value) => {
            if (typeof value !== "undefined") {
              if (value.length > 0) {
                var isValid = true;
                if (!value[0].type.includes("image")) {
                  isValid = false;
                }
                return isValid;
              }
            }
          }),
      }),
    ),
  });
  //react hook form
  const {
    register,
    control,
    handleSubmit,
    formState: { errors },
    reset,
  } = useForm({
    resolver: yupResolver(schema),
  });
  const { fields, append, remove } = useFieldArray({
    control,
    name: "Images",
  });
  const onSubmit = async (content) => {
    var data = await cakeApi.addAsync(content);

    var isUploadSuccess = true;
    if (data) {
      var cakeId = data.Id;
      content.Images.forEach(async (image) => {
        var uploadImage = new FormData();
        uploadImage.append("ImageFile", image.ImageFile[0]);
        uploadImage.append("CakeId", cakeId);
        uploadImage.append(
          "Caption",
          image.Caption ? image.Caption : "Cake Image",
        );
        uploadImage.append("SortOrder", image.SortOrder ? image.SortOrder : 1);
        uploadImage.append("IsDefault", image.IsDefault);

        var result = await imageApi.addAsync(uploadImage);
        if (!result) {
          isUploadSuccess = false;
        }
      });
    }

    if (data && isUploadSuccess) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: "Add cake successfully",
      });
      reset();
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Add cake failed",
      });
    }
  };
  async function refreshPage() {
    var data = await categoryApi.getAllAsync();
    if (data) {
      setCategories(data);
    }
  }
  useEffect(() => {
    refreshPage();
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
                            defaultValue=""
                          >
                            <option value="" disabled>
                              Select one
                            </option>
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
                        {...register("Description")}
                      />
                      <div
                        style={{ fontSize: 13 }}
                        className="text-danger fw-light mx-1 mt-2"
                      >
                        {errors.Description?.message}
                      </div>
                    </FormGroup>
                    <hr />
                    <Row className="d-flex align-items-center mb-4">
                      <h3>Images</h3>
                      <Button
                        outline
                        className="ml-4 "
                        color="danger"
                        onClick={() => remove(0)}
                      >
                        Remove
                      </Button>
                      <Button
                        outline
                        className="ml-2"
                        color="default"
                        onClick={() => append({ file: "" })}
                      >
                        Add
                      </Button>
                    </Row>

                    {fields.map((image, index) => (
                      <div key={image.id}>
                        <hr />
                        <FormGroup>
                          <label className="form-control-label">
                            Image {index + 1}
                          </label>
                          <input
                            className="form-control"
                            type="file"
                            {...register(`Images.${index}.ImageFile`)}
                          />

                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {typeof errors.Images !== "undefined"
                              ? errors.Images[index]?.ImageFile?.message
                              : ""}
                          </div>
                        </FormGroup>
                        <Row>
                          <Col lg="6">
                            <FormGroup>
                              <label className="form-control-label">
                                Caption (for alt image - SEO)
                              </label>
                              <input
                                className="form-control"
                                type="text"
                                placeholder="Ex: Chocolate Cake Image"
                                {...register(`Images.${index}.Caption`)}
                              />
                              <div
                                style={{ fontSize: 13 }}
                                className="text-danger fw-light mx-1 mt-2"
                              >
                                {typeof errors.Images !== "undefined"
                                  ? errors.Images[index]?.Caption?.message
                                  : ""}
                              </div>
                            </FormGroup>
                          </Col>
                          <Col lg="6">
                            <Row>
                              <FormGroup className="col-6">
                                <label className="form-control-label">
                                  Sort order
                                </label>
                                <input
                                  className="form-control"
                                  type="number"
                                  {...register(`Images.${index}.SortOrder`)}
                                />
                                <div
                                  style={{ fontSize: 13 }}
                                  className="text-danger fw-light mx-1 mt-2"
                                >
                                  {typeof errors.Images !== "undefined"
                                    ? errors.Images[index]?.SortOrder?.message
                                    : ""}
                                </div>
                              </FormGroup>
                              <FormGroup className="col-6 d-flex flex-column align-items-start">
                                <label className="form-control-label">
                                  Default Image
                                </label>
                                <label className="custom-toggle mt-2">
                                  <input
                                    type="checkbox"
                                    {...register(`Images.${index}.IsDefault`)}
                                  />
                                  <span className="custom-toggle-slider rounded-circle"></span>
                                </label>
                                <div
                                  style={{ fontSize: 13 }}
                                  className="text-danger fw-light mx-1 mt-2"
                                >
                                  {typeof errors.Images !== "undefined"
                                    ? errors.Images[index]?.IsDefault?.message
                                    : ""}
                                </div>
                              </FormGroup>
                            </Row>
                          </Col>
                        </Row>
                      </div>
                    ))}

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

export default CakeCreate;
